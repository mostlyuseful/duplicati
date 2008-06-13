#region Disclaimer / License
// Copyright (C) 2008, Kenneth Skovhede
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
namespace Duplicati
{
    partial class ServiceSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceSetup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainTree = new System.Windows.Forms.TreeView();
            this.TreeMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetupMenuStrip = new System.Windows.Forms.ToolStrip();
            this.AddButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddFolderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBackupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveButton = new System.Windows.Forms.ToolStripButton();
            this.PropertyTabs = new System.Windows.Forms.TabControl();
            this.OccurencePage = new System.Windows.Forms.TabPage();
            this.FilePage = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.scheduleSettings = new Duplicati.Service_controls.ScheduleSettings();
            this.taskSettings = new Duplicati.Service_controls.TaskSettingsBase();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TreeMenuStrip.SuspendLayout();
            this.SetupMenuStrip.SuspendLayout();
            this.PropertyTabs.SuspendLayout();
            this.OccurencePage.SuspendLayout();
            this.FilePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.OKBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 40);
            this.panel1.TabIndex = 0;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelBtn.Location = new System.Drawing.Point(209, 8);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(80, 24);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OKBtn.Location = new System.Drawing.Point(113, 8);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(80, 24);
            this.OKBtn.TabIndex = 0;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MainTree);
            this.splitContainer1.Panel1.Controls.Add(this.SetupMenuStrip);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PropertyTabs);
            this.splitContainer1.Size = new System.Drawing.Size(440, 477);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 1;
            // 
            // MainTree
            // 
            this.MainTree.ContextMenuStrip = this.TreeMenuStrip;
            this.MainTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTree.ImageIndex = 0;
            this.MainTree.ImageList = this.imageList;
            this.MainTree.LabelEdit = true;
            this.MainTree.Location = new System.Drawing.Point(0, 25);
            this.MainTree.Name = "MainTree";
            this.MainTree.SelectedImageIndex = 0;
            this.MainTree.Size = new System.Drawing.Size(146, 452);
            this.MainTree.TabIndex = 1;
            this.MainTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.MainTree_AfterLabelEdit);
            this.MainTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTree_AfterSelect);
            // 
            // TreeMenuStrip
            // 
            this.TreeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem});
            this.TreeMenuStrip.Name = "TreeMenuStrip";
            this.TreeMenuStrip.Size = new System.Drawing.Size(165, 26);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("playToolStripMenuItem.Image")));
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.playToolStripMenuItem.Text = "Run backup now";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // SetupMenuStrip
            // 
            this.SetupMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SetupMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton,
            this.RemoveButton});
            this.SetupMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SetupMenuStrip.Name = "SetupMenuStrip";
            this.SetupMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.SetupMenuStrip.Size = new System.Drawing.Size(146, 25);
            this.SetupMenuStrip.TabIndex = 0;
            this.SetupMenuStrip.Text = "toolStrip1";
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFolderMenu,
            this.AddBackupMenu});
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(29, 22);
            this.AddButton.Text = "toolStripDropDownButton1";
            // 
            // AddFolderMenu
            // 
            this.AddFolderMenu.Image = ((System.Drawing.Image)(resources.GetObject("AddFolderMenu.Image")));
            this.AddFolderMenu.Name = "AddFolderMenu";
            this.AddFolderMenu.Size = new System.Drawing.Size(119, 22);
            this.AddFolderMenu.Text = "Folder";
            this.AddFolderMenu.Click += new System.EventHandler(this.AddFolderMenu_Click);
            // 
            // AddBackupMenu
            // 
            this.AddBackupMenu.Image = ((System.Drawing.Image)(resources.GetObject("AddBackupMenu.Image")));
            this.AddBackupMenu.Name = "AddBackupMenu";
            this.AddBackupMenu.Size = new System.Drawing.Size(119, 22);
            this.AddBackupMenu.Text = "Backup";
            this.AddBackupMenu.Click += new System.EventHandler(this.AddBackupMenu_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(23, 22);
            this.RemoveButton.Text = "toolStripButton2";
            // 
            // PropertyTabs
            // 
            this.PropertyTabs.Controls.Add(this.OccurencePage);
            this.PropertyTabs.Controls.Add(this.FilePage);
            this.PropertyTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyTabs.Location = new System.Drawing.Point(0, 0);
            this.PropertyTabs.Name = "PropertyTabs";
            this.PropertyTabs.SelectedIndex = 0;
            this.PropertyTabs.Size = new System.Drawing.Size(290, 477);
            this.PropertyTabs.TabIndex = 0;
            this.PropertyTabs.Visible = false;
            // 
            // OccurencePage
            // 
            this.OccurencePage.Controls.Add(this.scheduleSettings);
            this.OccurencePage.Location = new System.Drawing.Point(4, 22);
            this.OccurencePage.Name = "OccurencePage";
            this.OccurencePage.Size = new System.Drawing.Size(282, 451);
            this.OccurencePage.TabIndex = 0;
            this.OccurencePage.Text = "Occurence";
            this.OccurencePage.UseVisualStyleBackColor = true;
            // 
            // FilePage
            // 
            this.FilePage.Controls.Add(this.taskSettings);
            this.FilePage.Location = new System.Drawing.Point(4, 22);
            this.FilePage.Name = "FilePage";
            this.FilePage.Size = new System.Drawing.Size(282, 451);
            this.FilePage.TabIndex = 1;
            this.FilePage.Text = "Files";
            this.FilePage.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Folder");
            this.imageList.Images.SetKeyName(1, "Backup");
            // 
            // scheduleSettings
            // 
            this.scheduleSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleSettings.Location = new System.Drawing.Point(0, 0);
            this.scheduleSettings.Name = "scheduleSettings";
            this.scheduleSettings.Size = new System.Drawing.Size(282, 451);
            this.scheduleSettings.TabIndex = 0;
            // 
            // taskSettings
            // 
            this.taskSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskSettings.Location = new System.Drawing.Point(0, 0);
            this.taskSettings.Name = "taskSettings";
            this.taskSettings.Size = new System.Drawing.Size(282, 451);
            this.taskSettings.TabIndex = 0;
            // 
            // ServiceSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 517);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServiceSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duplicati Setup";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.TreeMenuStrip.ResumeLayout(false);
            this.SetupMenuStrip.ResumeLayout(false);
            this.SetupMenuStrip.PerformLayout();
            this.PropertyTabs.ResumeLayout(false);
            this.OccurencePage.ResumeLayout(false);
            this.FilePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView MainTree;
        private System.Windows.Forms.ToolStrip SetupMenuStrip;
        private System.Windows.Forms.TabControl PropertyTabs;
        private System.Windows.Forms.TabPage OccurencePage;
        private System.Windows.Forms.TabPage FilePage;
        private Duplicati.Service_controls.ScheduleSettings scheduleSettings;
        private System.Windows.Forms.ToolStripDropDownButton AddButton;
        private System.Windows.Forms.ToolStripMenuItem AddFolderMenu;
        private System.Windows.Forms.ToolStripMenuItem AddBackupMenu;
        private System.Windows.Forms.ToolStripButton RemoveButton;
        private Duplicati.Service_controls.TaskSettingsBase taskSettings;
        private System.Windows.Forms.ContextMenuStrip TreeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
    }
}