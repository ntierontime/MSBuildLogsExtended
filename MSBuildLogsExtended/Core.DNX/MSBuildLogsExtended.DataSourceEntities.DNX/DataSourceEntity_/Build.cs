using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
#if WINDOWS_PHONE
#else
using System.ComponentModel.DataAnnotations;
#endif

namespace MSBuildLogsExtended.DataSourceEntities
{
    /// <summary>
    /// Entity class, used across the solution. <see cref="Build"/>
    /// </summary>
    //[DataContract]
	public partial class Build  : Framework.PropertyChangedNotifier, MSBuildLogsExtended.EntityContracts.IBuild 
	{ 





		#region Storage Fields

        public System.Int64 m_Id;

        public System.Int32 m_SolutionId;

        public System.String m_Name;

        public System.String m_Description;

        public System.DateTime m_BuildStartTime;


		#endregion Storage Fields


    

		#region constructors

        /// <summary>
        /// default constructor
        /// Initializes a new instance of the <see cref=" Build"/> class.
        /// </summary>
		public Build()
		{
			this.Id = default(long);
			this.SolutionId = default(int);
			this.Name = null;
			this.Description = null;
			this.BuildStartTime = DateTime.Now;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref=" Build"/> class with .Net value type parameters.
        /// </summary>
        /// <param name="id">property value of Id</param>
        /// <param name="solutionId">property value of SolutionId</param>
        /// <param name="name">property value of Name</param>
        /// <param name="description">property value of Description</param>
        /// <param name="buildStartTime">property value of BuildStartTime</param>
		public Build(
			System.Int64 id
			,System.Int32 solutionId
			,System.String name
			,System.String description
			,System.DateTime buildStartTime
			)
		{
			this.m_Id = id;
			this.m_SolutionId = solutionId;
			this.m_Name = name;
			this.m_Description = description;
			this.m_BuildStartTime = buildStartTime;
		}

        /// <summary>
        /// Initializes/clone a new instance of the <see cref=" Build"/> class.
        /// </summary>
        /// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuild"/></param>
        public Build(MSBuildLogsExtended.EntityContracts.IBuild item)
        {
            MSBuildLogsExtended.EntityContracts.IBuildHelper.Copy<MSBuildLogsExtended.EntityContracts.IBuild, Build>(item, this);
        }


		#endregion constructors

		#region properties

				[DataMember]
#if (WINDOWS_PHONE)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="Id_is_required")]
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
#if (WINDOWS_PHONE)

#else
		[Display(Name = "SolutionId", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="SolutionId_is_required")]
#endif
        public System.Int32 SolutionId
        {
            get
            {
                return m_SolutionId;
            }
            set
            {
                m_SolutionId = value;
                RaisePropertyChanged("SolutionId");
            }
        }

				[DataMember]
#if (WINDOWS_PHONE)

#else
		[Display(Name = "Name", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="Name_is_required")]
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
#if (WINDOWS_PHONE)

#else
		[Display(Name = "Description", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.String Description
        {
            get
            {
                return m_Description;
            }
            set
            {
                m_Description = value;
                RaisePropertyChanged("Description");
            }
        }

				[DataMember]
#if (WINDOWS_PHONE)

#else
		[Display(Name = "BuildStartTime", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="BuildStartTime_is_required")]
#endif
        public System.DateTime BuildStartTime
        {
            get
            {
                return m_BuildStartTime;
            }
            set
            {
                m_BuildStartTime = value;
                RaisePropertyChanged("BuildStartTime");
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
            return MSBuildLogsExtended.EntityContracts.IBuildHelper.ToString<Build>(this);
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
            bool _retval = obj is Build;
            if (_retval == true)
            {
                _retval = MSBuildLogsExtended.EntityContracts.IBuildHelper.Equals<Build, Build>(this, (Build)obj);
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

		#region Method of Build GetAClone()

        /// <summary>
        /// Gets the A clone.
        /// </summary>
        /// <returns>a new instance with same value</returns>
        public Build GetAClone()
        {
            return MSBuildLogsExtended.EntityContracts.IBuildHelper.Clone<Build, Build>(this);
        }


		#endregion Method of Build GetAClone()

		#region Nested Views classes and their collection classes 3


        /// <summary>
        /// View "Default" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class Default :Framework.PropertyChangedNotifier, MSBuildLogsExtended.EntityContracts.IBuild
		{

			#region Storage Fields

        public System.String m_Solution_S1_1_Name;

        public System.Int64 m_Id;

        public System.Int32 m_SolutionId;

        public System.String m_Name;

        public System.String m_Description;

        public System.DateTime m_BuildStartTime;


			#endregion Storage Fields

			#region Constructors

			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuild"/></param>
			public Default()
			{
				this.Solution_S1_1_Name = null;
				this.Id = default(long);
				this.SolutionId = default(int);
				this.Name = null;
				this.Description = null;
				this.BuildStartTime = DateTime.Now;
			}
			/*
			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuild"/></param>
			public Default(MSBuildLogsExtended.EntityContracts.IBuild item)
			{
				MSBuildLogsExtended.EntityContracts.IBuildHelper.Copy<MSBuildLogsExtended.EntityContracts.IBuild, Default>(item, this);
			}
			*/
			#endregion Constructors


			#region properties

					[DataMember]
#if (WINDOWS_PHONE)

#else
		[Display(Name = "Solution_S1_1_Name", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
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
#if (WINDOWS_PHONE)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="Id_is_required")]
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
#if (WINDOWS_PHONE)

#else
		[Display(Name = "SolutionId", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.Int32 SolutionId
        {
            get
            {
                return m_SolutionId;
            }
            set
            {
                m_SolutionId = value;
                RaisePropertyChanged("SolutionId");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE)

#else
		[Display(Name = "Name", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="Name_is_required")]
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
#if (WINDOWS_PHONE)

#else
		[Display(Name = "Description", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.String Description
        {
            get
            {
                return m_Description;
            }
            set
            {
                m_Description = value;
                RaisePropertyChanged("Description");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE)

#else
		[Display(Name = "BuildStartTime", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="BuildStartTime_is_required")]
#endif
        public System.DateTime BuildStartTime
        {
            get
            {
                return m_BuildStartTime;
            }
            set
            {
                m_BuildStartTime = value;
                RaisePropertyChanged("BuildStartTime");
            }
        }


			#endregion properties

            #region Method of Build.Default  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public Default GetAClone()
            {
                Default cloned = new Default();

			cloned.m_Solution_S1_1_Name = m_Solution_S1_1_Name;
			cloned.m_Id = m_Id;
			cloned.m_SolutionId = m_SolutionId;
			cloned.m_Name = m_Name;
			cloned.m_Description = m_Description;
			cloned.m_BuildStartTime = m_BuildStartTime;

                return cloned;
            }


            #endregion Method of Build.Default  GetAClone()
		}

        /// <summary>
        /// View "Default" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class DefaultCollection
			:  List<Default>
		{ 
		}

        /// <summary>
        /// message definition of "Default", pass single entry, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfDefault
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<Default>
		{
		}

        /// <summary>
        /// message definition of "Default", pass a collection of instances, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfDefaultCollection
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultCollection>
		{
		}


        /// <summary>
        /// View "DefaultGroupedDataView" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class DefaultGroupedDataView :Framework.PropertyChangedNotifier
		{

			#region Storage Fields

        public System.Int32 m_SolutionId;

        public System.Int64 m_CountPerFK;

        public System.String m_Name;


			#endregion Storage Fields

			#region Constructors

			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuild"/></param>
			public DefaultGroupedDataView()
			{
				this.SolutionId = default(int);
				this.CountPerFK = default(long);
				this.Name = null;
			}
			/*
			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuild"/></param>
			public DefaultGroupedDataView(MSBuildLogsExtended.EntityContracts.IBuild item)
			{
				MSBuildLogsExtended.EntityContracts.IBuildHelper.Copy<MSBuildLogsExtended.EntityContracts.IBuild, DefaultGroupedDataView>(item, this);
			}
			*/
			#endregion Constructors


			#region properties

					[DataMember]
#if (WINDOWS_PHONE)

#else
		[Display(Name = "SolutionId", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="SolutionId_is_required")]
#endif
        public System.Int32 SolutionId
        {
            get
            {
                return m_SolutionId;
            }
            set
            {
                m_SolutionId = value;
                RaisePropertyChanged("SolutionId");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE)

#else
		[Display(Name = "CountPerFK", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
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
#if (WINDOWS_PHONE)

#else
		[Display(Name = "Name", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
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


			#endregion properties

            #region Method of Build.DefaultGroupedDataView  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public DefaultGroupedDataView GetAClone()
            {
                DefaultGroupedDataView cloned = new DefaultGroupedDataView();

			cloned.m_SolutionId = m_SolutionId;
			cloned.m_CountPerFK = m_CountPerFK;
			cloned.m_Name = m_Name;

                return cloned;
            }


            #endregion Method of Build.DefaultGroupedDataView  GetAClone()
		}

        /// <summary>
        /// View "DefaultGroupedDataView" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class DefaultGroupedDataViewCollection
			:  List<DefaultGroupedDataView>
		{ 
		}

        /// <summary>
        /// message definition of "DefaultGroupedDataView", pass single entry, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfDefaultGroupedDataView
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultGroupedDataView>
		{
		}

        /// <summary>
        /// message definition of "DefaultGroupedDataView", pass a collection of instances, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfDefaultGroupedDataViewCollection
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultGroupedDataViewCollection>
		{
		}


        /// <summary>
        /// View "KeyInformation" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class KeyInformation :Framework.PropertyChangedNotifier, MSBuildLogsExtended.EntityContracts.IBuildIdentifier
		{

			#region Storage Fields

        public System.Int64 m_Id;


			#endregion Storage Fields

			#region Constructors

			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuild"/></param>
			public KeyInformation()
			{
				this.Id = default(long);
			}
			/*
			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuild"/></param>
			public KeyInformation(MSBuildLogsExtended.EntityContracts.IBuild item)
			{
				MSBuildLogsExtended.EntityContracts.IBuildHelper.Copy<MSBuildLogsExtended.EntityContracts.IBuild, KeyInformation>(item, this);
			}
			*/
			#endregion Constructors


			#region properties

					[DataMember]
#if (WINDOWS_PHONE)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="Id_is_required")]
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

            #region Method of Build.KeyInformation  GetAClone()

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


            #endregion Method of Build.KeyInformation  GetAClone()
		}

        /// <summary>
        /// View "KeyInformation" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class KeyInformationCollection
			:  List<KeyInformation>
		{ 
		}

        /// <summary>
        /// message definition of "KeyInformation", pass single entry, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfKeyInformation
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformation>
		{
		}

        /// <summary>
        /// message definition of "KeyInformation", pass a collection of instances, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfKeyInformationCollection
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformationCollection>
		{
		}




		#endregion Nested Views classes and their collection classes 3

	}



    /// <summary>
    /// a property defined when <see cref="Build"/> is used in other classes.
    /// </summary>
	public interface WithEntityContractBuild
	{ 
        /// <summary>
        /// Gets or sets Build.
        /// </summary>
        /// <value>
        /// The Build
        /// </value>
		Build Build { get; set; }
	}

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
    /// </summary>
    public class DataAccessLayerMessageOfEntityBuild
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<Build>
    {
    }
}