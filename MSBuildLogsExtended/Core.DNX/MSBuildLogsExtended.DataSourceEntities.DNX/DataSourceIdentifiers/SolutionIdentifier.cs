using System;
using System.Runtime.Serialization;

namespace MSBuildLogsExtended.DataSourceEntities
{
    /// <summary>
    /// table/entity identifier, inherit from entity interface, <see cref="MSBuildLogsExtended.EntityContracts.ISolutionIdentifier"/>
    /// </summary>
	public class SolutionIdentifier 
		: MSBuildLogsExtended.EntityContracts.ISolutionIdentifier
	{ 

		#region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionIdentifier"/> class.
        /// </summary>
		public SolutionIdentifier ()
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionIdentifier"/> class.
        /// </summary>
		public SolutionIdentifier (
System.Int32 id)
		{

			this.Id=id;

		}

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionIdentifier"/> class.
        /// </summary>
        public SolutionIdentifier(MSBuildLogsExtended.EntityContracts.ISolutionIdentifier item)
        {
            MSBuildLogsExtended.EntityContracts.ISolutionIdentifierHelper.Copy<MSBuildLogsExtended.EntityContracts.ISolutionIdentifier, SolutionIdentifier>(item, this);
        }

		#endregion constructors

		#region properties


        public System.Int32 Id { get; set; }


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
            return MSBuildLogsExtended.EntityContracts.ISolutionIdentifierHelper.ToString<SolutionIdentifier>(this);
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
            bool _retval = obj is SolutionIdentifier;
            if (_retval == true)
            {
                _retval = MSBuildLogsExtended.EntityContracts.ISolutionIdentifierHelper.Equals<SolutionIdentifier, SolutionIdentifier>(this, (SolutionIdentifier)obj);
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

		#region Method of SolutionIdentifier GetAClone()

        /// <summary>
        /// Gets the A clone, using clone method in entity contract helper in EntityContract project.
        /// </summary>
        /// <returns>a new instance of <see cref="SolutionIdentifier"/></returns>
        public SolutionIdentifier GetAClone()
        {
            return MSBuildLogsExtended.EntityContracts.ISolutionIdentifierHelper.Clone<SolutionIdentifier, SolutionIdentifier>(this);
        }


		#endregion Method of SolutionIdentifier GetAClone()
	}

    /// <summary>
    ///  a property defined when <see cref="WithIdentifierContractSolution"/> is used in other classes.
    /// </summary>
    public interface WithIdentifierContractSolution
    {
        /// <summary>
        /// Gets or sets the SolutionIdentifier
        /// </summary>
        /// <value>
        /// The SolutionIdentifier
        /// </value>
        SolutionIdentifier SolutionIdentifier { get; set; }
    }
}