using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
#if (WINDOWS_PHONE || XAMARIN)
#else
using System.ComponentModel.DataAnnotations;
#endif

namespace MSBuildLogsExtended.DataSourceEntities
{
    /// <summary>
    /// Entity class, used across the solution. <see cref="BuildLog"/>
    /// </summary>
    //[DataContract]
	public partial class BuildLog  : Framework.PropertyChangedNotifier, MSBuildLogsExtended.EntityContracts.IBuildLog 
	{ 





		#region Storage Fields

        public System.Int64 m_Id;

        public System.Int64 m_BuildId;

        public System.Int32 m_BuildEventCodeId;

        public System.String m_Message;

        public System.DateTime m_EventTime;


		#endregion Storage Fields


    

		#region constructors

        /// <summary>
        /// default constructor
        /// Initializes a new instance of the <see cref=" BuildLog"/> class.
        /// </summary>
		public BuildLog()
		{
			this.Id = default(long);
			this.BuildId = default(long);
			this.BuildEventCodeId = default(int);
			this.Message = null;
			this.EventTime = DateTime.Now;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref=" BuildLog"/> class with .Net value type parameters.
        /// </summary>
        /// <param name="id">property value of Id</param>
        /// <param name="buildId">property value of BuildId</param>
        /// <param name="buildEventCodeId">property value of BuildEventCodeId</param>
        /// <param name="message">property value of Message</param>
        /// <param name="eventTime">property value of EventTime</param>
		public BuildLog(
			System.Int64 id
			,System.Int64 buildId
			,System.Int32 buildEventCodeId
			,System.String message
			,System.DateTime eventTime
			)
		{
			this.m_Id = id;
			this.m_BuildId = buildId;
			this.m_BuildEventCodeId = buildEventCodeId;
			this.m_Message = message;
			this.m_EventTime = eventTime;
		}

        /// <summary>
        /// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
        /// </summary>
        /// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuildLog"/></param>
        public BuildLog(MSBuildLogsExtended.EntityContracts.IBuildLog item)
        {
            MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Copy<MSBuildLogsExtended.EntityContracts.IBuildLog, BuildLog>(item, this);
        }


		#endregion constructors

		#region properties

				[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="Id_is_required")]
#endif
        public System.Int64 Id
        {
            get
            {
                return m_Id;
            }
            set
            {
                m_Id = value;
                RaisePropertyChanged("Id");
            }
        }

				[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "BuildId", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="BuildId_is_required")]
#endif
        public System.Int64 BuildId
        {
            get
            {
                return m_BuildId;
            }
            set
            {
                m_BuildId = value;
                RaisePropertyChanged("BuildId");
            }
        }

				[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "BuildEventCodeId", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="BuildEventCodeId_is_required")]
#endif
        public System.Int32 BuildEventCodeId
        {
            get
            {
                return m_BuildEventCodeId;
            }
            set
            {
                m_BuildEventCodeId = value;
                RaisePropertyChanged("BuildEventCodeId");
            }
        }

				[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Message", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
#endif
        public System.String Message
        {
            get
            {
                return m_Message;
            }
            set
            {
                m_Message = value;
                RaisePropertyChanged("Message");
            }
        }

				[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "EventTime", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="EventTime_is_required")]
#endif
        public System.DateTime EventTime
        {
            get
            {
                return m_EventTime;
            }
            set
            {
                m_EventTime = value;
                RaisePropertyChanged("EventTime");
            }
        }


		#endregion properties

        #region override methods

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return MSBuildLogsExtended.EntityContracts.IBuildLogHelper.ToString<BuildLog>(this);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            bool _retval = obj is BuildLog;
            if (_retval == true)
            {
                _retval = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Equals<BuildLog, BuildLog>(this, (BuildLog)obj);
            }
            return _retval;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        #endregion override methods

		#region Method of BuildLog GetAClone()

        /// <summary>
        /// Gets the A clone.
        /// </summary>
        /// <returns>a new instance with same value</returns>
        public BuildLog GetAClone()
        {
            return MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<BuildLog, BuildLog>(this);
        }


		#endregion Method of BuildLog GetAClone()

		#region Nested Views classes and their collection classes 3


        /// <summary>
        /// View "Default" class of <see cref="BuildLog"/>, used across the solution. 
        /// </summary>
		public partial class Default :Framework.PropertyChangedNotifier, MSBuildLogsExtended.EntityContracts.IBuildLog
		{

			#region Storage Fields

        public System.String m_Build_B1_1_Name;

        public System.Int64 m_Id;

        public System.Int32 m_Solution_S1_1Id;

        public System.String m_Solution_S1_1_Name;

        public System.String m_BuildEventCode_B2_1_Name;

        public System.Int64 m_BuildId;

        public System.Int32 m_BuildEventCodeId;

        public System.String m_Message;

        public System.DateTime m_EventTime;


			#endregion Storage Fields

			#region Constructors

			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuildLog"/></param>
			public Default()
			{
				this.Build_B1_1_Name = null;
				this.Id = default(long);
				this.Solution_S1_1Id = default(int);
				this.Solution_S1_1_Name = null;
				this.BuildEventCode_B2_1_Name = null;
				this.BuildId = default(long);
				this.BuildEventCodeId = default(int);
				this.Message = null;
				this.EventTime = DateTime.Now;
			}
			/*
			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuildLog"/></param>
			public Default(MSBuildLogsExtended.EntityContracts.IBuildLog item)
			{
				MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Copy<MSBuildLogsExtended.EntityContracts.IBuildLog, Default>(item, this);
			}
			*/
			#endregion Constructors


			#region properties

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Build_B1_1_Name", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
#endif
        public System.String Build_B1_1_Name
        {
            get
            {
                return m_Build_B1_1_Name;
            }
            set
            {
                m_Build_B1_1_Name = value;
                RaisePropertyChanged("Build_B1_1_Name");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="Id_is_required")]
#endif
        public System.Int64 Id
        {
            get
            {
                return m_Id;
            }
            set
            {
                m_Id = value;
                RaisePropertyChanged("Id");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Solution_S1_1Id", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
#endif
        public System.Int32 Solution_S1_1Id
        {
            get
            {
                return m_Solution_S1_1Id;
            }
            set
            {
                m_Solution_S1_1Id = value;
                RaisePropertyChanged("Solution_S1_1Id");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Solution_S1_1_Name", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
#endif
        public System.String Solution_S1_1_Name
        {
            get
            {
                return m_Solution_S1_1_Name;
            }
            set
            {
                m_Solution_S1_1_Name = value;
                RaisePropertyChanged("Solution_S1_1_Name");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "BuildEventCode_B2_1_Name", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
#endif
        public System.String BuildEventCode_B2_1_Name
        {
            get
            {
                return m_BuildEventCode_B2_1_Name;
            }
            set
            {
                m_BuildEventCode_B2_1_Name = value;
                RaisePropertyChanged("BuildEventCode_B2_1_Name");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "BuildId", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
#endif
        public System.Int64 BuildId
        {
            get
            {
                return m_BuildId;
            }
            set
            {
                m_BuildId = value;
                RaisePropertyChanged("BuildId");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "BuildEventCodeId", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
#endif
        public System.Int32 BuildEventCodeId
        {
            get
            {
                return m_BuildEventCodeId;
            }
            set
            {
                m_BuildEventCodeId = value;
                RaisePropertyChanged("BuildEventCodeId");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Message", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
#endif
        public System.String Message
        {
            get
            {
                return m_Message;
            }
            set
            {
                m_Message = value;
                RaisePropertyChanged("Message");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "EventTime", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="EventTime_is_required")]
#endif
        public System.DateTime EventTime
        {
            get
            {
                return m_EventTime;
            }
            set
            {
                m_EventTime = value;
                RaisePropertyChanged("EventTime");
            }
        }


			#endregion properties

            #region Method of BuildLog.Default  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public Default GetAClone()
            {
                Default cloned = new Default();

			cloned.m_Build_B1_1_Name = m_Build_B1_1_Name;
			cloned.m_Id = m_Id;
			cloned.m_Solution_S1_1Id = m_Solution_S1_1Id;
			cloned.m_Solution_S1_1_Name = m_Solution_S1_1_Name;
			cloned.m_BuildEventCode_B2_1_Name = m_BuildEventCode_B2_1_Name;
			cloned.m_BuildId = m_BuildId;
			cloned.m_BuildEventCodeId = m_BuildEventCodeId;
			cloned.m_Message = m_Message;
			cloned.m_EventTime = m_EventTime;

                return cloned;
            }


            #endregion Method of BuildLog.Default  GetAClone()
		}

        /// <summary>
        /// View "Default" class of <see cref="BuildLog"/>, used across the solution. 
        /// </summary>
		public partial class DefaultCollection
			:  List<Default>
		{ 
		}

        /// <summary>
        /// message definition of "Default", pass single entry, from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfDefault
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<Default>
		{
		}

        /// <summary>
        /// message definition of "Default", pass a collection of instances, from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfDefaultCollection
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultCollection>
		{
		}


        /// <summary>
        /// View "DefaultGroupedDataView" class of <see cref="BuildLog"/>, used across the solution. 
        /// </summary>
		public partial class DefaultGroupedDataView :Framework.PropertyChangedNotifier
		{

			#region Storage Fields

        public System.Int64 m_BuildId;

        public System.Int32 m_BuildEventCodeId;

        public System.Int64 m_CountPerFK;

        public System.String m_Name;

        public System.Int32 m_Solution_S1_1Id;


			#endregion Storage Fields

			#region Constructors

			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuildLog"/></param>
			public DefaultGroupedDataView()
			{
				this.BuildId = default(long);
				this.BuildEventCodeId = default(int);
				this.CountPerFK = default(long);
				this.Name = null;
				this.Solution_S1_1Id = default(int);
			}
			/*
			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuildLog"/></param>
			public DefaultGroupedDataView(MSBuildLogsExtended.EntityContracts.IBuildLog item)
			{
				MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Copy<MSBuildLogsExtended.EntityContracts.IBuildLog, DefaultGroupedDataView>(item, this);
			}
			*/
			#endregion Constructors


			#region properties

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "BuildId", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="BuildId_is_required")]
#endif
        public System.Int64 BuildId
        {
            get
            {
                return m_BuildId;
            }
            set
            {
                m_BuildId = value;
                RaisePropertyChanged("BuildId");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "BuildEventCodeId", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="BuildEventCodeId_is_required")]
#endif
        public System.Int32 BuildEventCodeId
        {
            get
            {
                return m_BuildEventCodeId;
            }
            set
            {
                m_BuildEventCodeId = value;
                RaisePropertyChanged("BuildEventCodeId");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "CountPerFK", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
#endif
        public System.Int64 CountPerFK
        {
            get
            {
                return m_CountPerFK;
            }
            set
            {
                m_CountPerFK = value;
                RaisePropertyChanged("CountPerFK");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Name", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
#endif
        public System.String Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
                RaisePropertyChanged("Name");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Solution_S1_1Id", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
#endif
        public System.Int32 Solution_S1_1Id
        {
            get
            {
                return m_Solution_S1_1Id;
            }
            set
            {
                m_Solution_S1_1Id = value;
                RaisePropertyChanged("Solution_S1_1Id");
            }
        }


			#endregion properties

            #region Method of BuildLog.DefaultGroupedDataView  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public DefaultGroupedDataView GetAClone()
            {
                DefaultGroupedDataView cloned = new DefaultGroupedDataView();

			cloned.m_BuildId = m_BuildId;
			cloned.m_BuildEventCodeId = m_BuildEventCodeId;
			cloned.m_CountPerFK = m_CountPerFK;
			cloned.m_Name = m_Name;
			cloned.m_Solution_S1_1Id = m_Solution_S1_1Id;

                return cloned;
            }


            #endregion Method of BuildLog.DefaultGroupedDataView  GetAClone()
		}

        /// <summary>
        /// View "DefaultGroupedDataView" class of <see cref="BuildLog"/>, used across the solution. 
        /// </summary>
		public partial class DefaultGroupedDataViewCollection
			:  List<DefaultGroupedDataView>
		{ 
		}

        /// <summary>
        /// message definition of "DefaultGroupedDataView", pass single entry, from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfDefaultGroupedDataView
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultGroupedDataView>
		{
		}

        /// <summary>
        /// message definition of "DefaultGroupedDataView", pass a collection of instances, from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfDefaultGroupedDataViewCollection
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultGroupedDataViewCollection>
		{
		}


        /// <summary>
        /// View "KeyInformation" class of <see cref="BuildLog"/>, used across the solution. 
        /// </summary>
		public partial class KeyInformation :Framework.PropertyChangedNotifier, MSBuildLogsExtended.EntityContracts.IBuildLogIdentifier
		{

			#region Storage Fields

        public System.Int64 m_Id;


			#endregion Storage Fields

			#region Constructors

			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuildLog"/></param>
			public KeyInformation()
			{
				this.Id = default(long);
			}
			/*
			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuildLog"/></param>
			public KeyInformation(MSBuildLogsExtended.EntityContracts.IBuildLog item)
			{
				MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Copy<MSBuildLogsExtended.EntityContracts.IBuildLog, KeyInformation>(item, this);
			}
			*/
			#endregion Constructors


			#region properties

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="Id_is_required")]
#endif
        public System.Int64 Id
        {
            get
            {
                return m_Id;
            }
            set
            {
                m_Id = value;
                RaisePropertyChanged("Id");
            }
        }


			#endregion properties

            #region Method of BuildLog.KeyInformation  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public KeyInformation GetAClone()
            {
                KeyInformation cloned = new KeyInformation();

			cloned.m_Id = m_Id;

                return cloned;
            }


            #endregion Method of BuildLog.KeyInformation  GetAClone()
		}

        /// <summary>
        /// View "KeyInformation" class of <see cref="BuildLog"/>, used across the solution. 
        /// </summary>
		public partial class KeyInformationCollection
			:  List<KeyInformation>
		{ 
		}

        /// <summary>
        /// message definition of "KeyInformation", pass single entry, from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfKeyInformation
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformation>
		{
		}

        /// <summary>
        /// message definition of "KeyInformation", pass a collection of instances, from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfKeyInformationCollection
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformationCollection>
		{
		}




		#endregion Nested Views classes and their collection classes 3

	}



    /// <summary>
    /// a property defined when <see cref="BuildLog"/> is used in other classes.
    /// </summary>
	public interface WithEntityContractBuildLog
	{ 
        /// <summary>
        /// Gets or sets BuildLog.
        /// </summary>
        /// <value>
        /// The BuildLog
        /// </value>
		BuildLog BuildLog { get; set; }
	}

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
    /// </summary>
    public class DataAccessLayerMessageOfEntityBuildLog
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<BuildLog>
    {
    }
}