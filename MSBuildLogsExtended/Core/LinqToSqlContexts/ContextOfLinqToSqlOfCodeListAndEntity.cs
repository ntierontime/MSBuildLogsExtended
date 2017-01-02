#pragma warning disable 1591
namespace MSBuildLogsExtended.LinqToSqlContexts
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	public partial class MSBuildLogsExtendedContext : System.Data.Linq.DataContext
	{
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

		#region constructors

		public MSBuildLogsExtendedContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MSBuildLogsExtendedContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MSBuildLogsExtendedContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MSBuildLogsExtendedContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}

		#endregion constructors

		#region tables


		public System.Data.Linq.Table<Build> Builds
		{
			get
			{
				return this.GetTable<Build>();
			}
		}



		public System.Data.Linq.Table<BuildEventCode> BuildEventCodes
		{
			get
			{
				return this.GetTable<BuildEventCode>();
			}
		}



		public System.Data.Linq.Table<BuildLog> BuildLogs
		{
			get
			{
				return this.GetTable<BuildLog>();
			}
		}



		public System.Data.Linq.Table<Solution> Solutions
		{
			get
			{
				return this.GetTable<Solution>();
			}
		}



		#endregion tables

		#region Binary Column Load and Update Methods 



		#endregion Binary Column Load and Update Methods 

		#region GetAscendant... and GetDescendant... Methods 



		#endregion GetAscendant... and GetDescendant... Methods 

		#region Extensibility Method Definitions
	    partial void OnCreated();


		partial void InsertBuild(Build instance);
		partial void UpdateBuild(Build instance);
		partial void DeleteBuild(Build instance);


		partial void InsertBuildEventCode(BuildEventCode instance);
		partial void UpdateBuildEventCode(BuildEventCode instance);
		partial void DeleteBuildEventCode(BuildEventCode instance);


		partial void InsertBuildLog(BuildLog instance);
		partial void UpdateBuildLog(BuildLog instance);
		partial void DeleteBuildLog(BuildLog instance);


		partial void InsertSolution(Solution instance);
		partial void UpdateSolution(Solution instance);
		partial void DeleteSolution(Solution instance);


		#endregion Extensibility Method Definitions

	}
#region Type of dbo.Build, the Member is Builds, the type is Build

	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Build")]
	public partial class Build : INotifyPropertyChanging, INotifyPropertyChanged
	{

		#region constructors

		public Build()
		{

			#region initialize fields for Association, FK

			this._Solution = default(EntityRef<Solution>);



			#endregion initialize fields for Association, FK


			#region initialize fields for Association, not a FK


			this._BuildLogs = new EntitySet<BuildLog>(new Action<BuildLog>(this.attach_BuildLogs), new Action<BuildLog>(this.detach_BuildLogs));



			#endregion initialize fields for Association, not a FK

			OnCreated();
		}

		#endregion constructors

		#region INotifyPropertyChanging or INotifyPropertyChanged related

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion INotifyPropertyChanging or INotifyPropertyChanged related


		#region event handler attach and detach, not a FK



		private void attach_BuildLogs(BuildLog entity)
		{
			this.SendPropertyChanging();
			entity.Build = this;
		}
		
		private void detach_BuildLogs(BuildLog entity)
		{
			this.SendPropertyChanging();
			entity.Build = null;
		}



		#endregion event handler attach and detach, not a FK

		#region fields, storage for Properties


		private System.Int64 _Id;


		private System.Int32 _SolutionId;


		private System.String _Name;


		private System.String _Description;


		private System.DateTime _BuildStartTime;



		#endregion fields, storage for Properties

		#region fields, storage for Association, FK


		private EntityRef<Solution> _Solution;



		#endregion fields, storage for Association, FK


		#region fields, storage for Association, not a FK


		private EntitySet<BuildLog> _BuildLogs;



		#endregion fields, storage for Association, not a FK

		#region Properties

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SolutionId", DbType="Int NOT NULL", IsPrimaryKey=false)]
		public System.Int32 SolutionId
		{
			get
			{
				return this._SolutionId;
			}
			set
			{
				if ((this._SolutionId != value))
				{
					if (this._Solution.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSolutionIdChanging(value);
					this.SendPropertyChanging();
					this._SolutionId = value;
					this.SendPropertyChanged("SolutionId");
					this.OnSolutionIdChanged();
				}
			}
		}



		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert)]
		public System.Int64 Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}



		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", IsPrimaryKey=false, IsDbGenerated=false)]
		public System.String Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}



		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(1500) NULL", IsPrimaryKey=false, IsDbGenerated=false)]
		public System.String Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}



		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuildStartTime", DbType="DateTime NOT NULL", IsPrimaryKey=false, IsDbGenerated=false)]
		public System.DateTime BuildStartTime
		{
			get
			{
				return this._BuildStartTime;
			}
			set
			{
				if ((this._BuildStartTime != value))
				{
					this.OnBuildStartTimeChanging(value);
					this.SendPropertyChanging();
					this._BuildStartTime = value;
					this.SendPropertyChanged("BuildStartTime");
					this.OnBuildStartTimeChanged();
				}
			}
		}



		#endregion Properties


		#region Properties for Association, FK


		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Build_Solution", Storage="_Solution", ThisKey="SolutionId", OtherKey="Id", IsForeignKey=true)]
		public Solution Solution
		{
			get
			{
				return this._Solution.Entity;
			}
			set
			{
				Solution previousValue = this._Solution.Entity;
				if (((previousValue != value) 
							|| (this._Solution.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Solution.Entity = null;
						previousValue.Builds.Remove(this);
					}
					this._Solution.Entity = value;
					if ((value != null))
					{
						value.Builds.Add(this);
						this._SolutionId = value.Id;
					}
					else
					{
						this._SolutionId = default(System.Int32);
					}
					this.SendPropertyChanged("Solution");
				}
			}
		}



		#endregion Properties for Association, FK


		#region Properties for Association, not a FK


		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_BuildLog_Build", Storage="_BuildLogs", ThisKey="Id", OtherKey="BuildId")]
		public EntitySet<BuildLog> BuildLogs
		{
			get
			{
				return this._BuildLogs;
			}
			set
			{
				this._BuildLogs.Assign(value);
			}
		}



		#endregion Properties for Association, not a FK

		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();


		partial void OnIdChanging(System.Int64 value);
		partial void OnIdChanged();


		partial void OnSolutionIdChanging(System.Int32 value);
		partial void OnSolutionIdChanged();


		partial void OnNameChanging(System.String value);
		partial void OnNameChanged();


		partial void OnDescriptionChanging(System.String value);
		partial void OnDescriptionChanged();


		partial void OnBuildStartTimeChanging(System.DateTime value);
		partial void OnBuildStartTimeChanged();


		#endregion Extensibility Method Definitions
	}

	#endregion Type of dbo.Build, the Member is Builds, the type is Build
	#region Type of dbo.BuildEventCode, the Member is BuildEventCodes, the type is BuildEventCode

	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BuildEventCode")]
	public partial class BuildEventCode : INotifyPropertyChanging, INotifyPropertyChanged
	{

		#region constructors

		public BuildEventCode()
		{

			#region initialize fields for Association, FK


			#endregion initialize fields for Association, FK


			#region initialize fields for Association, not a FK


			this._BuildLogs = new EntitySet<BuildLog>(new Action<BuildLog>(this.attach_BuildLogs), new Action<BuildLog>(this.detach_BuildLogs));



			#endregion initialize fields for Association, not a FK

			OnCreated();
		}

		#endregion constructors

		#region INotifyPropertyChanging or INotifyPropertyChanged related

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion INotifyPropertyChanging or INotifyPropertyChanged related


		#region event handler attach and detach, not a FK



		private void attach_BuildLogs(BuildLog entity)
		{
			this.SendPropertyChanging();
			entity.BuildEventCode = this;
		}
		
		private void detach_BuildLogs(BuildLog entity)
		{
			this.SendPropertyChanging();
			entity.BuildEventCode = null;
		}



		#endregion event handler attach and detach, not a FK

		#region fields, storage for Properties


		private System.Int32 _Id;


		private System.String _EventCode;


		private System.String _Description;



		#endregion fields, storage for Properties

		#region fields, storage for Association, FK



		#endregion fields, storage for Association, FK


		#region fields, storage for Association, not a FK


		private EntitySet<BuildLog> _BuildLogs;



		#endregion fields, storage for Association, not a FK

		#region Properties


		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert)]
		public System.Int32 Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}



		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventCode", DbType="NVarChar(100) NOT NULL", IsPrimaryKey=false, IsDbGenerated=false)]
		public System.String EventCode
		{
			get
			{
				return this._EventCode;
			}
			set
			{
				if ((this._EventCode != value))
				{
					this.OnEventCodeChanging(value);
					this.SendPropertyChanging();
					this._EventCode = value;
					this.SendPropertyChanged("EventCode");
					this.OnEventCodeChanged();
				}
			}
		}



		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(1500) NULL", IsPrimaryKey=false, IsDbGenerated=false)]
		public System.String Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}



		#endregion Properties


		#region Properties for Association, FK



		#endregion Properties for Association, FK


		#region Properties for Association, not a FK


		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_BuildLog_BuildEventCode", Storage="_BuildLogs", ThisKey="Id", OtherKey="BuildEventCodeId")]
		public EntitySet<BuildLog> BuildLogs
		{
			get
			{
				return this._BuildLogs;
			}
			set
			{
				this._BuildLogs.Assign(value);
			}
		}



		#endregion Properties for Association, not a FK

		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();


		partial void OnIdChanging(System.Int32 value);
		partial void OnIdChanged();


		partial void OnEventCodeChanging(System.String value);
		partial void OnEventCodeChanged();


		partial void OnDescriptionChanging(System.String value);
		partial void OnDescriptionChanged();


		#endregion Extensibility Method Definitions
	}

	#endregion Type of dbo.BuildEventCode, the Member is BuildEventCodes, the type is BuildEventCode
	#region Type of dbo.BuildLog, the Member is BuildLogs, the type is BuildLog

	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BuildLog")]
	public partial class BuildLog : INotifyPropertyChanging, INotifyPropertyChanged
	{

		#region constructors

		public BuildLog()
		{

			#region initialize fields for Association, FK

			this._Build = default(EntityRef<Build>);


			this._BuildEventCode = default(EntityRef<BuildEventCode>);



			#endregion initialize fields for Association, FK


			#region initialize fields for Association, not a FK



			#endregion initialize fields for Association, not a FK

			OnCreated();
		}

		#endregion constructors

		#region INotifyPropertyChanging or INotifyPropertyChanged related

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion INotifyPropertyChanging or INotifyPropertyChanged related


		#region event handler attach and detach, not a FK



		#endregion event handler attach and detach, not a FK

		#region fields, storage for Properties


		private System.Int64 _Id;


		private System.Int64 _BuildId;


		private System.Int32 _BuildEventCodeId;


		private System.String _Message;


		private System.DateTime _EventTime;



		#endregion fields, storage for Properties

		#region fields, storage for Association, FK


		private EntityRef<Build> _Build;


		private EntityRef<BuildEventCode> _BuildEventCode;



		#endregion fields, storage for Association, FK


		#region fields, storage for Association, not a FK



		#endregion fields, storage for Association, not a FK

		#region Properties

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuildId", DbType="BigInt NOT NULL", IsPrimaryKey=false)]
		public System.Int64 BuildId
		{
			get
			{
				return this._BuildId;
			}
			set
			{
				if ((this._BuildId != value))
				{
					if (this._Build.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBuildIdChanging(value);
					this.SendPropertyChanging();
					this._BuildId = value;
					this.SendPropertyChanged("BuildId");
					this.OnBuildIdChanged();
				}
			}
		}


		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuildEventCodeId", DbType="Int NOT NULL", IsPrimaryKey=false)]
		public System.Int32 BuildEventCodeId
		{
			get
			{
				return this._BuildEventCodeId;
			}
			set
			{
				if ((this._BuildEventCodeId != value))
				{
					if (this._BuildEventCode.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBuildEventCodeIdChanging(value);
					this.SendPropertyChanging();
					this._BuildEventCodeId = value;
					this.SendPropertyChanged("BuildEventCodeId");
					this.OnBuildEventCodeIdChanged();
				}
			}
		}



		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert)]
		public System.Int64 Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}



		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="NVarChar(1500) NULL", IsPrimaryKey=false, IsDbGenerated=false)]
		public System.String Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this.OnMessageChanging(value);
					this.SendPropertyChanging();
					this._Message = value;
					this.SendPropertyChanged("Message");
					this.OnMessageChanged();
				}
			}
		}



		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventTime", DbType="DateTime NOT NULL", IsPrimaryKey=false, IsDbGenerated=false)]
		public System.DateTime EventTime
		{
			get
			{
				return this._EventTime;
			}
			set
			{
				if ((this._EventTime != value))
				{
					this.OnEventTimeChanging(value);
					this.SendPropertyChanging();
					this._EventTime = value;
					this.SendPropertyChanged("EventTime");
					this.OnEventTimeChanged();
				}
			}
		}



		#endregion Properties


		#region Properties for Association, FK


		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_BuildLog_Build", Storage="_Build", ThisKey="BuildId", OtherKey="Id", IsForeignKey=true)]
		public Build Build
		{
			get
			{
				return this._Build.Entity;
			}
			set
			{
				Build previousValue = this._Build.Entity;
				if (((previousValue != value) 
							|| (this._Build.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Build.Entity = null;
						previousValue.BuildLogs.Remove(this);
					}
					this._Build.Entity = value;
					if ((value != null))
					{
						value.BuildLogs.Add(this);
						this._BuildId = value.Id;
					}
					else
					{
						this._BuildId = default(System.Int64);
					}
					this.SendPropertyChanged("Build");
				}
			}
		}


		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_BuildLog_BuildEventCode", Storage="_BuildEventCode", ThisKey="BuildEventCodeId", OtherKey="Id", IsForeignKey=true)]
		public BuildEventCode BuildEventCode
		{
			get
			{
				return this._BuildEventCode.Entity;
			}
			set
			{
				BuildEventCode previousValue = this._BuildEventCode.Entity;
				if (((previousValue != value) 
							|| (this._BuildEventCode.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BuildEventCode.Entity = null;
						previousValue.BuildLogs.Remove(this);
					}
					this._BuildEventCode.Entity = value;
					if ((value != null))
					{
						value.BuildLogs.Add(this);
						this._BuildEventCodeId = value.Id;
					}
					else
					{
						this._BuildEventCodeId = default(System.Int32);
					}
					this.SendPropertyChanged("BuildEventCode");
				}
			}
		}



		#endregion Properties for Association, FK


		#region Properties for Association, not a FK



		#endregion Properties for Association, not a FK

		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();


		partial void OnIdChanging(System.Int64 value);
		partial void OnIdChanged();


		partial void OnBuildIdChanging(System.Int64 value);
		partial void OnBuildIdChanged();


		partial void OnBuildEventCodeIdChanging(System.Int32 value);
		partial void OnBuildEventCodeIdChanged();


		partial void OnMessageChanging(System.String value);
		partial void OnMessageChanged();


		partial void OnEventTimeChanging(System.DateTime value);
		partial void OnEventTimeChanged();


		#endregion Extensibility Method Definitions
	}

	#endregion Type of dbo.BuildLog, the Member is BuildLogs, the type is BuildLog
	#region Type of dbo.Solution, the Member is Solutions, the type is Solution

	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Solution")]
	public partial class Solution : INotifyPropertyChanging, INotifyPropertyChanged
	{

		#region constructors

		public Solution()
		{

			#region initialize fields for Association, FK


			#endregion initialize fields for Association, FK


			#region initialize fields for Association, not a FK


			this._Builds = new EntitySet<Build>(new Action<Build>(this.attach_Builds), new Action<Build>(this.detach_Builds));



			#endregion initialize fields for Association, not a FK

			OnCreated();
		}

		#endregion constructors

		#region INotifyPropertyChanging or INotifyPropertyChanged related

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion INotifyPropertyChanging or INotifyPropertyChanged related


		#region event handler attach and detach, not a FK



		private void attach_Builds(Build entity)
		{
			this.SendPropertyChanging();
			entity.Solution = this;
		}
		
		private void detach_Builds(Build entity)
		{
			this.SendPropertyChanging();
			entity.Solution = null;
		}



		#endregion event handler attach and detach, not a FK

		#region fields, storage for Properties


		private System.Int32 _Id;


		private System.String _ExternalParentId;


		private System.String _Name;


		private System.String _Description;



		#endregion fields, storage for Properties

		#region fields, storage for Association, FK



		#endregion fields, storage for Association, FK


		#region fields, storage for Association, not a FK


		private EntitySet<Build> _Builds;



		#endregion fields, storage for Association, not a FK

		#region Properties


		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.OnInsert)]
		public System.Int32 Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}



		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExternalParentId", DbType="NVarChar(100) NULL", IsPrimaryKey=false, IsDbGenerated=false)]
		public System.String ExternalParentId
		{
			get
			{
				return this._ExternalParentId;
			}
			set
			{
				if ((this._ExternalParentId != value))
				{
					this.OnExternalParentIdChanging(value);
					this.SendPropertyChanging();
					this._ExternalParentId = value;
					this.SendPropertyChanged("ExternalParentId");
					this.OnExternalParentIdChanged();
				}
			}
		}



		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", IsPrimaryKey=false, IsDbGenerated=false)]
		public System.String Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}



		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(1500) NULL", IsPrimaryKey=false, IsDbGenerated=false)]
		public System.String Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}



		#endregion Properties


		#region Properties for Association, FK



		#endregion Properties for Association, FK


		#region Properties for Association, not a FK


		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Build_Solution", Storage="_Builds", ThisKey="Id", OtherKey="SolutionId")]
		public EntitySet<Build> Builds
		{
			get
			{
				return this._Builds;
			}
			set
			{
				this._Builds.Assign(value);
			}
		}



		#endregion Properties for Association, not a FK

		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();


		partial void OnIdChanging(System.Int32 value);
		partial void OnIdChanged();


		partial void OnExternalParentIdChanging(System.String value);
		partial void OnExternalParentIdChanged();


		partial void OnNameChanging(System.String value);
		partial void OnNameChanged();


		partial void OnDescriptionChanging(System.String value);
		partial void OnDescriptionChanged();


		#endregion Extensibility Method Definitions
	}

	#endregion Type of dbo.Solution, the Member is Solutions, the type is Solution




}
#pragma warning restore 1591