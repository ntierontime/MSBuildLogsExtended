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
    /// Entity class, used across the solution. <see cref="Solution"/>
    /// </summary>
    //[DataContract]
	public partial class Solution  : Framework.PropertyChangedNotifier, MSBuildLogsExtended.EntityContracts.ISolution 
	{ 





		#region Storage Fields

        public System.Int32 m_Id;

        public System.String m_ExternalParentId;

        public System.String m_Name;

        public System.String m_Description;


		#endregion Storage Fields


    

		#region constructors

        /// <summary>
        /// default constructor
        /// Initializes a new instance of the <see cref=" Solution"/> class.
        /// </summary>
		public Solution()
		{
			this.Id = default(int);
			this.ExternalParentId = null;
			this.Name = null;
			this.Description = null;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref=" Solution"/> class with .Net value type parameters.
        /// </summary>
        /// <param name="id">property value of Id</param>
        /// <param name="externalParentId">property value of ExternalParentId</param>
        /// <param name="name">property value of Name</param>
        /// <param name="description">property value of Description</param>
		public Solution(
			System.Int32 id
			,System.String externalParentId
			,System.String name
			,System.String description
			)
		{
			this.m_Id = id;
			this.m_ExternalParentId = externalParentId;
			this.m_Name = name;
			this.m_Description = description;
		}

        /// <summary>
        /// Initializes/clone a new instance of the <see cref=" Solution"/> class.
        /// </summary>
        /// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.ISolution"/></param>
        public Solution(MSBuildLogsExtended.EntityContracts.ISolution item)
        {
            MSBuildLogsExtended.EntityContracts.ISolutionHelper.Copy<MSBuildLogsExtended.EntityContracts.ISolution, Solution>(item, this);
        }


		#endregion constructors

		#region properties

				[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution), ErrorMessageResourceName="Id_is_required")]
#endif
        public System.Int32 Id
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
		[Display(Name = "ExternalParentId", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution))]
		[StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution), ErrorMessageResourceName="The_length_of_ExternalParentId_should_be_0_to_100")]
#endif
        public System.String ExternalParentId
        {
            get
            {
                return m_ExternalParentId;
            }
            set
            {
                m_ExternalParentId = value;
                RaisePropertyChanged("ExternalParentId");
            }
        }

				[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Name", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution), ErrorMessageResourceName="Name_is_required")]
		[StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution), ErrorMessageResourceName="The_length_of_Name_should_be_0_to_100")]
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
		[Display(Name = "Description", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution))]
		[StringLengthAttribute(1500, ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution), ErrorMessageResourceName="The_length_of_Description_should_be_0_to_1500")]
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
            return MSBuildLogsExtended.EntityContracts.ISolutionHelper.ToString<Solution>(this);
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
            bool _retval = obj is Solution;
            if (_retval == true)
            {
                _retval = MSBuildLogsExtended.EntityContracts.ISolutionHelper.Equals<Solution, Solution>(this, (Solution)obj);
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

		#region Method of Solution GetAClone()

        /// <summary>
        /// Gets the A clone.
        /// </summary>
        /// <returns>a new instance with same value</returns>
        public Solution GetAClone()
        {
            return MSBuildLogsExtended.EntityContracts.ISolutionHelper.Clone<Solution, Solution>(this);
        }


		#endregion Method of Solution GetAClone()

		#region Nested Views classes and their collection classes 1


        /// <summary>
        /// View "KeyInformation" class of <see cref="Solution"/>, used across the solution. 
        /// </summary>
		public partial class KeyInformation :Framework.PropertyChangedNotifier, MSBuildLogsExtended.EntityContracts.ISolutionIdentifier
		{

			#region Storage Fields

        public System.Int32 m_Id;

        public System.String m_Name;


			#endregion Storage Fields

			#region Constructors

			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Solution"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.ISolution"/></param>
			public KeyInformation()
			{
				this.Id = default(int);
				this.Name = null;
			}
			/*
			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Solution"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.ISolution"/></param>
			public KeyInformation(MSBuildLogsExtended.EntityContracts.ISolution item)
			{
				MSBuildLogsExtended.EntityContracts.ISolutionHelper.Copy<MSBuildLogsExtended.EntityContracts.ISolution, KeyInformation>(item, this);
			}
			*/
			#endregion Constructors


			#region properties

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution), ErrorMessageResourceName="Id_is_required")]
#endif
        public System.Int32 Id
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
		[Display(Name = "Name", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution), ErrorMessageResourceName="Name_is_required")]
		[StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution), ErrorMessageResourceName="The_length_of_Name_should_be_0_to_100")]
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

            #region Method of Solution.KeyInformation  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public KeyInformation GetAClone()
            {
                KeyInformation cloned = new KeyInformation();

			cloned.m_Id = m_Id;
			cloned.m_Name = m_Name;

                return cloned;
            }


            #endregion Method of Solution.KeyInformation  GetAClone()
		}

        /// <summary>
        /// View "KeyInformation" class of <see cref="Solution"/>, used across the solution. 
        /// </summary>
		public partial class KeyInformationCollection
			:  List<KeyInformation>
		{ 
		}

        /// <summary>
        /// message definition of "KeyInformation", pass single entry, from database, to business logic layer. <see cref="Solution"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfKeyInformation
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformation>
		{
		}

        /// <summary>
        /// message definition of "KeyInformation", pass a collection of instances, from database, to business logic layer. <see cref="Solution"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfKeyInformationCollection
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformationCollection>
		{
		}




		#endregion Nested Views classes and their collection classes 1

	}



    /// <summary>
    /// a property defined when <see cref="Solution"/> is used in other classes.
    /// </summary>
	public interface WithEntityContractSolution
	{ 
        /// <summary>
        /// Gets or sets Solution.
        /// </summary>
        /// <value>
        /// The Solution
        /// </value>
		Solution Solution { get; set; }
	}

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="Solution"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
    /// </summary>
    public class DataAccessLayerMessageOfEntitySolution
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<Solution>
    {
    }
}

