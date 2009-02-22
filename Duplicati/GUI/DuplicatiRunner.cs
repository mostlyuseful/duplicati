#region Disclaimer / License
// Copyright (C) 2009, Kenneth Skovhede
// http://www.hexad.dk, opensource@hexad.dk
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
// 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Duplicati.Datamodel;
using Duplicati.Library.Main;

namespace Duplicati.GUI
{
    /// <summary>
    /// This class translates tasks into Duplicati calls, and executes them
    /// </summary>
    public class DuplicatiRunner
    {
        public void ExecuteTask(IDuplicityTask task)
        {
            Dictionary<string, string> options = new Dictionary<string,string>();
            task.GetOptions(options);
            string results = "";

            try
            {
                switch (task.TaskType)
                {
                    case DuplicityTaskType.FullBackup:
                    case DuplicityTaskType.IncrementalBackup:
                        {
                            Library.Core.TempFolder tf = null;
                            try
                            {
                                if (task.Task.IncludeSetup)
                                {
                                    //Make a copy of the current database
                                    tf = new Duplicati.Library.Core.TempFolder();
                                    string filename = System.IO.Path.Combine(tf, System.IO.Path.GetFileName(Program.DatabasePath));

                                    System.IO.File.Copy(Program.DatabasePath, filename, true);
                                    using (System.Data.IDbConnection con = new System.Data.SQLite.SQLiteConnection())
                                    {
                                        con.ConnectionString = "Data Source=" + filename;
                                        con.Open();

                                        using (System.Data.IDbCommand cmd = con.CreateCommand())
                                        {
                                            //Remove all log data to minimize the size of the database
                                            cmd.CommandText = "DELETE FROM CommandQueue;";
                                            cmd.ExecuteNonQuery();
                                            cmd.CommandText = "DELETE FROM Log;";
                                            cmd.ExecuteNonQuery();
                                            cmd.CommandText = "DELETE FROM LogBlob;";
                                            cmd.ExecuteNonQuery();

                                            //Free up unused space
                                            cmd.CommandText = "VACUUM;";
                                        }
                                    }

                                    options["signature-control-files"] = filename;
                                }
                                results = Interface.Backup(task.SourcePath, task.TargetPath, options);
                            }
                            finally
                            {
                                if (tf != null)
                                    tf.Dispose();
                            }
                            break;
                        }
                    case DuplicityTaskType.ListBackups:

                        List<string> res = new List<string>();
                        foreach (BackupEntry be in Interface.ParseFileList(task.SourcePath, options))
                        {
                            res.Add(be.Time.ToString());
                            foreach (BackupEntry bei in be.Incrementals)
                                res.Add(bei.Time.ToString());
                        }

                        (task as ListBackupsTask).Backups = res.ToArray();
                        break;
                    case DuplicityTaskType.ListFiles:
                        (task as ListFilesTask).Files = Interface.ListContent(task.SourcePath, options);
                        break;

                    case DuplicityTaskType.RemoveAllButNFull:
                        results = Interface.RemoveAllButNFull(task.SourcePath, options);
                        break;
                    case DuplicityTaskType.RemoveOlderThan:
                        results = Interface.RemoveOlderThan(task.SourcePath, options);
                        break;
                    case DuplicityTaskType.Restore:
                        options["file-to-restore"] = ((RestoreTask)task).SourceFiles;
                        if (options.ContainsKey("filter"))
                            options.Remove("filter");
                        results = Interface.Restore(task.SourcePath, task.TargetPath, options);
                        break;

                    case DuplicityTaskType.RestoreSetup:
                        Interface.RestoreControlFiles(task.SourcePath, task.TargetPath, options);
                        break;
                    default:
                        return;
                }
            }
            catch (Exception ex)
            {
                while (ex is System.Reflection.TargetInvocationException && ex.InnerException != null)
                    ex = ex.InnerException;
                results = "Error: " + ex.Message;

            }

            task.RaiseTaskCompleted(results);

            if (task.Schedule != null)
                ((System.Data.LightDatamodel.IDataFetcherCached)task.Schedule.DataParent).CommitRecursiveWithRelations();

            if (task.TaskType == DuplicityTaskType.FullBackup || task.TaskType == DuplicityTaskType.IncrementalBackup)
            {
                if (task.Schedule.Task.KeepFull > 0)
                    ExecuteTask(new RemoveAllButNFullTask(task.Schedule, (int)task.Schedule.Task.KeepFull));
                if (!string.IsNullOrEmpty(task.Schedule.Task.KeepTime))
                    ExecuteTask(new RemoveOlderThanTask(task.Schedule, task.Schedule.Task.KeepTime));
            }
        }


        private void PerformBackup(Schedule schedule, bool forceFull, string fullAfter)
        {
            if (forceFull)
                ExecuteTask(new FullBackupTask(schedule));
            else
                ExecuteTask(new IncrementalBackupTask(schedule, fullAfter));
        }

        public void Restore(Schedule schedule, DateTime when, string where)
        {
            ExecuteTask(new RestoreTask(schedule, where, when));
        }

        public string[] ListBackups(Schedule schedule)
        {
            ListBackupsTask task = new ListBackupsTask(schedule);
            ExecuteTask(task);
            return task.Backups;
        }

        public IList<string> ListFiles(Schedule schedule, DateTime when)
        {
            ListFilesTask task = new ListFilesTask(schedule, when);
            ExecuteTask(task);
            return task.Files;
        }

        public void IncrementalBackup(Schedule schedule)
        {
            PerformBackup(schedule, false, null);
        }

        public void FullBackup(Schedule schedule)
        {
            PerformBackup(schedule, true, null);
        }

    }
}