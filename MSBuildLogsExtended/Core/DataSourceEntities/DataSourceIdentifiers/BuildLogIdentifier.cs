using System;
using System.Runtime.Serialization;

namespace MSBuildLogsExtended.DataSourceEntities
{
    /// <summary>
    /// table/entity identifier, inherit from entity interface, <see cref="MSBuildLogsExtended.EntityContracts.IBuildLogIdentifier"/>
    /// </summary>
	public partial class BuildLogIdentifier 
		: MSBuildLogsExtended.EntityContracts.IBuildLogIdentifier
	{ 

		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogIdentifier"/> class.
        /// </summary>
		public BuildLogIdentifier ()
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogIdentifier"/> class.
        /// </summary>
		public BuildLogIdentifier (
System.Int64 id)
		{

			this.Id=id;

		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildLogIdentifier"/> class.
        /// </summary>
        public BuildLogIdentifier(MSBuildLogsExtended.EntityContracts.IBuildLogIdentifier item)
        {
            MSBuildLogsExtended.EntityContracts.IBuildLogIdentifierHelper.Copy<MSBuildLogsExtended.EntityContracts.IBuildLogIdentifier, BuildLogIdentifier>(item, this);
        }

		#endregion constructors

		#region properties


        public System.Int64 Id { get; set; }


		#endregion properties

        #region override methods
		
		/// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance, using ToString method in entity contract helper in EntityContract project
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return MSBuildLogsExtended.EntityContracts.IBuildLogIdentifierHelper.ToString<BuildLogIdentifier>(this);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance , using Equals method in entity contract helper in EntityContract project
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            bool _retval = obj is BuildLogIdentifier;
            if (_retval == true)
            {
                _retval = MSBuildLogsExtended.EntityContracts.IBuildLogIdentifierHelper.Equals<BuildLogIdentifier, BuildLogIdentifier>(this, (BuildLogIdentifier)obj);
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

		#region Method of BuildLogIdentifier GetAClone()

        /// <summary>
        /// Gets the A clone, using clone method in entity contract helper in EntityContract project.
        /// </summary>
        /// <returns>a new instance of <see cref="BuildLogIdentifier"/></returns>
        public BuildLogIdentifier GetAClone()
        {
            return MSBuildLogsExtended.EntityContracts.IBuildLogIdentifierHelper.Clone<BuildLogIdentifier, BuildLogIdentifier>(this);
        }


		#endregion Method of BuildLogIdentifier GetAClone()
	}

    /// <summary>
    ///  a property defined when <see cref="WithIdentifierContractBuildLog"/> is used in other classes.
    /// </summary>
    public partial interface WithIdentifierContractBuildLog
    {
        /// <summary>
        /// Gets or sets the BuildLogIdentifier
        /// </summary>
        /// <value>
        /// The BuildLogIdentifier
        /// </value>
        BuildLogIdentifier BuildLogIdentifier { get; set; }
    }
}