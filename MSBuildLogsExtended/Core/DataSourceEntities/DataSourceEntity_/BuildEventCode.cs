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
    /// Entity class, used across the solution. <see cref="BuildEventCode"/>
    /// </summary>
    //[DataContract]
	public partial class BuildEventCode  : Framework.PropertyChangedNotifier, MSBuildLogsExtended.EntityContracts.IBuildEventCode 
	{ 





		#region Storage Fields

        public System.Int32 m_Id;

        public System.String m_EventCode;

        public System.String m_Description;


		#endregion Storage Fields


    

		#region constructors

        /// <summary>
        /// default constructor
        /// Initializes a new instance of the <see cref=" BuildEventCode"/> class.
        /// </summary>
		public BuildEventCode()
		{
			this.Id = default(int);
			this.EventCode = null;
			this.Description = null;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref=" BuildEventCode"/> class with .Net value type parameters.
        /// </summary>
        /// <param name="id">property value of Id</param>
        /// <param name="eventCode">property value of EventCode</param>
        /// <param name="description">property value of Description</param>
		public BuildEventCode(
			System.Int32 id
			,System.String eventCode
			,System.String description
			)
		{
			this.m_Id = id;
			this.m_EventCode = eventCode;
			this.m_Description = description;
		}

        /// <summary>
        /// Initializes/clone a new instance of the <see cref=" BuildEventCode"/> class.
        /// </summary>
        /// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuildEventCode"/></param>
        public BuildEventCode(MSBuildLogsExtended.EntityContracts.IBuildEventCode item)
        {
            MSBuildLogsExtended.EntityContracts.IBuildEventCodeHelper.Copy<MSBuildLogsExtended.EntityContracts.IBuildEventCode, BuildEventCode>(item, this);
        }


		#endregion constructors

		#region properties

				[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode), ErrorMessageResourceName="Id_is_required")]
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
		[Display(Name = "EventCode", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode), ErrorMessageResourceName="EventCode_is_required")]
#endif
        public System.String EventCode
        {
            get
            {
                return m_EventCode;
            }
            set
            {
                m_EventCode = value;
                RaisePropertyChanged("EventCode");
            }
        }

				[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Description", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode))]
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
            return MSBuildLogsExtended.EntityContracts.IBuildEventCodeHelper.ToString<BuildEventCode>(this);
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
            bool _retval = obj is BuildEventCode;
            if (_retval == true)
            {
                _retval = MSBuildLogsExtended.EntityContracts.IBuildEventCodeHelper.Equals<BuildEventCode, BuildEventCode>(this, (BuildEventCode)obj);
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

		#region Method of BuildEventCode GetAClone()

        /// <summary>
        /// Gets the A clone.
        /// </summary>
        /// <returns>a new instance with same value</returns>
        public BuildEventCode GetAClone()
        {
            return MSBuildLogsExtended.EntityContracts.IBuildEventCodeHelper.Clone<BuildEventCode, BuildEventCode>(this);
        }


		#endregion Method of BuildEventCode GetAClone()

		#region Nested Views classes and their collection classes 1


        /// <summary>
        /// View "KeyInformation" class of <see cref="BuildEventCode"/>, used across the solution. 
        /// </summary>
		public partial class KeyInformation :Framework.PropertyChangedNotifier, MSBuildLogsExtended.EntityContracts.IBuildEventCodeIdentifier
		{

			#region Storage Fields

        public System.Int32 m_Id;


			#endregion Storage Fields

			#region Constructors

			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" BuildEventCode"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuildEventCode"/></param>
			public KeyInformation()
			{
				this.Id = default(int);
			}
			/*
			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" BuildEventCode"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildLogsExtended.EntityContracts.IBuildEventCode"/></param>
			public KeyInformation(MSBuildLogsExtended.EntityContracts.IBuildEventCode item)
			{
				MSBuildLogsExtended.EntityContracts.IBuildEventCodeHelper.Copy<MSBuildLogsExtended.EntityContracts.IBuildEventCode, KeyInformation>(item, this);
			}
			*/
			#endregion Constructors


			#region properties

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode), ErrorMessageResourceName="Id_is_required")]
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


			#endregion properties

            #region Method of BuildEventCode.KeyInformation  GetAClone()

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


            #endregion Method of BuildEventCode.KeyInformation  GetAClone()
		}

        /// <summary>
        /// View "KeyInformation" class of <see cref="BuildEventCode"/>, used across the solution. 
        /// </summary>
		public partial class KeyInformationCollection
			:  List<KeyInformation>
		{ 
		}

        /// <summary>
        /// message definition of "KeyInformation", pass single entry, from database, to business logic layer. <see cref="BuildEventCode"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfKeyInformation
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformation>
		{
		}

        /// <summary>
        /// message definition of "KeyInformation", pass a collection of instances, from database, to business logic layer. <see cref="BuildEventCode"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfKeyInformationCollection
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformationCollection>
		{
		}




		#endregion Nested Views classes and their collection classes 1

	}



    /// <summary>
    /// a property defined when <see cref="BuildEventCode"/> is used in other classes.
    /// </summary>
	public interface WithEntityContractBuildEventCode
	{ 
        /// <summary>
        /// Gets or sets BuildEventCode.
        /// </summary>
        /// <value>
        /// The BuildEventCode
        /// </value>
		BuildEventCode BuildEventCode { get; set; }
	}

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="BuildEventCode"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
    /// </summary>
    public class DataAccessLayerMessageOfEntityBuildEventCode
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<BuildEventCode>
    {
    }
}