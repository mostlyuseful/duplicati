/// <metadata>
/// <creator>This class was created by DataClassFileBuilder (LightDatamodel)</creator>
/// <provider name="System.Data.LightDatamodel.SQLiteDataProvider" connectionstring="Version=3;Data Source=C:\Documents and Settings\Kenneth\Dokumenter\duplicati\Duplicati\Datamodel\Duplicati.sqlite;" />
/// <type>Table</type>
/// <namespace>Duplicati.Datamodel</namespace>
/// <name>Log</name>
/// <sql></sql>
/// </metadata>

namespace Duplicati.Datamodel
{

	public partial class Log : System.Data.LightDatamodel.DataClassBase
	{

#region " private members "

		[System.Data.LightDatamodel.MemberModifierAutoIncrement()]
		private System.Int64 m_ID = 0;
		private System.Int64 m_TaskID = 0;
		private System.DateTime m_EndTime = new System.DateTime(1, 1, 1);
		private System.DateTime m_BeginTime = new System.DateTime(1, 1, 1);
		private System.String m_Action = "";
		private System.String m_SubAction = "";
		private System.Int64 m_Transfersize = 0;
		private System.String m_ParsedStatus = "";
		private System.Int64 m_LogBlobID = 0;
#endregion

#region " unique value "

		public override object UniqueValue {get{return m_ID;}}
		public override string UniqueColumn {get{return "ID";}}
#endregion

#region " properties "

		public System.Int64 ID
		{
			get{return m_ID;}
			set{object oldvalue = m_ID;OnBeforeDataChange(this, "ID", oldvalue, value);m_ID = value;OnAfterDataChange(this, "ID", oldvalue, value);}
		}

		public System.Int64 TaskID
		{
			get{return m_TaskID;}
			set{object oldvalue = m_TaskID;OnBeforeDataChange(this, "TaskID", oldvalue, value);m_TaskID = value;OnAfterDataChange(this, "TaskID", oldvalue, value);}
		}

		public System.DateTime EndTime
		{
			get{return m_EndTime;}
			set{object oldvalue = m_EndTime;OnBeforeDataChange(this, "EndTime", oldvalue, value);m_EndTime = value;OnAfterDataChange(this, "EndTime", oldvalue, value);}
		}

		public System.DateTime BeginTime
		{
			get{return m_BeginTime;}
			set{object oldvalue = m_BeginTime;OnBeforeDataChange(this, "BeginTime", oldvalue, value);m_BeginTime = value;OnAfterDataChange(this, "BeginTime", oldvalue, value);}
		}

		public System.String Action
		{
			get{return m_Action;}
			set{object oldvalue = m_Action;OnBeforeDataChange(this, "Action", oldvalue, value);m_Action = value;OnAfterDataChange(this, "Action", oldvalue, value);}
		}

		public System.String SubAction
		{
			get{return m_SubAction;}
			set{object oldvalue = m_SubAction;OnBeforeDataChange(this, "SubAction", oldvalue, value);m_SubAction = value;OnAfterDataChange(this, "SubAction", oldvalue, value);}
		}

		public System.Int64 Transfersize
		{
			get{return m_Transfersize;}
			set{object oldvalue = m_Transfersize;OnBeforeDataChange(this, "Transfersize", oldvalue, value);m_Transfersize = value;OnAfterDataChange(this, "Transfersize", oldvalue, value);}
		}

		public System.String ParsedStatus
		{
			get{return m_ParsedStatus;}
			set{object oldvalue = m_ParsedStatus;OnBeforeDataChange(this, "ParsedStatus", oldvalue, value);m_ParsedStatus = value;OnAfterDataChange(this, "ParsedStatus", oldvalue, value);}
		}

		public System.Int64 LogBlobID
		{
			get{return m_LogBlobID;}
			set{object oldvalue = m_LogBlobID;OnBeforeDataChange(this, "LogBlobID", oldvalue, value);m_LogBlobID = value;OnAfterDataChange(this, "LogBlobID", oldvalue, value);}
		}

#endregion

#region " referenced properties "

		public Task OwnerTask
		{
			get{ return base.RelationManager.GetReferenceObject<Task>("OwnerTask", this); }
			set{ base.RelationManager.SetReferenceObject<Task>("OwnerTask", this, value); }
		}

		public LogBlob LogBlob
		{
			get{ return base.RelationManager.GetReferenceObject<LogBlob>("LogBlob", this); }
			set{ base.RelationManager.SetReferenceObject<LogBlob>("LogBlob", this, value); }
		}

#endregion

	}

}