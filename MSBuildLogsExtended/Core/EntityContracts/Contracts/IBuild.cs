using System;
using System.Runtime.Serialization;

namespace MSBuildLogsExtended.EntityContracts
{
    /// <summary>
    /// definition of Build with parameters of .Net value type.
    /// </summary>
	public partial interface IBuild : IBuildIdentifier
	{ 

        System.Int32 SolutionId { get; set; }


        System.String Name { get; set; }


        System.String Description { get; set; }


        System.DateTime BuildStartTime { get; set; }

	}

    /// <summary>
    /// a property defined when <see cref="WithEntityContractBuild"/> is used in other classes.
    /// </summary>
    /// <typeparam name="T">a type inherits from <see cref="WithEntityContractBuild"/></typeparam>
	public partial interface WithEntityContractBuild<T>
        where T : IBuild
    {
        /// <summary>
        /// Gets or sets the Build
        /// </summary>
        /// <value>
        /// The Build
        /// </value>
        T Build { get; set; }
    }
}

