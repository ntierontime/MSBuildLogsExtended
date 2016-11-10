using System;
using System.Runtime.Serialization;

namespace MSBuildLogsExtended.EntityContracts
{
    /// <summary>
    /// definition of BuildEventCode with parameters of .Net value type.
    /// </summary>
	public interface IBuildEventCode : IBuildEventCodeIdentifier
	{ 

        System.String EventCode { get; set; }


        System.String Description { get; set; }

	}

    /// <summary>
    /// a property defined when <see cref="WithEntityContractBuildEventCode"/> is used in other classes.
    /// </summary>
    /// <typeparam name="T">a type inherits from <see cref="WithEntityContractBuildEventCode"/></typeparam>
	public interface WithEntityContractBuildEventCode<T>
        where T : IBuildEventCode
    {
        /// <summary>
        /// Gets or sets the BuildEventCode
        /// </summary>
        /// <value>
        /// The BuildEventCode
        /// </value>
        T BuildEventCode { get; set; }
    }
}

