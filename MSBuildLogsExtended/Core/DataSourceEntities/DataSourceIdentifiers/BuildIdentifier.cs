using System;
using System.Runtime.Serialization;

namespace MSBuildLogsExtended.DataSourceEntities
{
    /// <summary>
    /// table/entity identifier, inherit from entity interface, <see cref="MSBuildLogsExtended.EntityContracts.IBuildIdentifier"/>
    /// </summary>
	public class BuildIdentifier 
		: MSBuildLogsExtended.EntityContracts.IBuildIdentifier
	{ 

		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildIdentifier"/> class.
        /// </summary>
		public BuildIdentifier ()
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildIdentifier"/> class.
        /// </summary>
		public BuildIdentifier (
System.Int64 id)
		{

			this.Id=id;

		}

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildIdentifier"/> class.
        /// </summary>
        public BuildIdentifier(MSBuildLogsExtended.EntityContracts.IBuildIdentifier item)
        {
            MSBuildLogsExtended.EntityContracts.IBuildIdentifierHelper.Copy<MSBuildLogsExtended.EntityContracts.IBuildIdentifier, BuildIdentifier>(item, this);
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
            return MSBuildLogsExtended.EntityContracts.IBuildIdentifierHelper.ToString<BuildIdentifier>(this);
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
            bool _retval = obj is BuildIdentifier;
            if (_retval == true)
            {
                _retval = MSBuildLogsExtended.EntityContracts.IBuildIdentifierHelper.Equals<BuildIdentifier, BuildIdentifier>(this, (BuildIdentifier)obj);
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

		#region Method of BuildIdentifier GetAClone()

        /// <summary>
        /// Gets the A clone, using clone method in entity contract helper in EntityContract project.
        /// </summary>
        /// <returns>a new instance of <see cref="BuildIdentifier"/></returns>
        public BuildIdentifier GetAClone()
        {
            return MSBuildLogsExtended.EntityContracts.IBuildIdentifierHelper.Clone<BuildIdentifier, BuildIdentifier>(this);
        }


		#endregion Method of BuildIdentifier GetAClone()
	}

    /// <summary>
    ///  a property defined when <see cref="WithIdentifierContractBuild"/> is used in other classes.
    /// </summary>
    public interface WithIdentifierContractBuild
    {
        /// <summary>
        /// Gets or sets the BuildIdentifier
        /// </summary>
        /// <value>
        /// The BuildIdentifier
        /// </value>
        BuildIdentifier BuildIdentifier { get; set; }
    }
}