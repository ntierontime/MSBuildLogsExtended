using System;
using System.Runtime.Serialization;

namespace MSBuildLogsExtended.EntityContracts
{
    /// <summary>
    /// definition of Solution with parameters of .Net value type.
    /// </summary>
	public interface ISolution : ISolutionIdentifier
	{ 

        System.String ExternalParentId { get; set; }


        System.String Name { get; set; }


        System.String Description { get; set; }

	}

    /// <summary>
    /// a property defined when <see cref="WithEntityContractSolution"/> is used in other classes.
    /// </summary>
    /// <typeparam name="T">a type inherits from <see cref="WithEntityContractSolution"/></typeparam>
	public interface WithEntityContractSolution<T>
        where T : ISolution
    {
        /// <summary>
        /// Gets or sets the Solution
        /// </summary>
        /// <value>
        /// The Solution
        /// </value>
        T Solution { get; set; }
    }
}

