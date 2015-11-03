using System;
using System.Runtime.Serialization;

namespace MSBuildLogsExtended.EntityContracts
{
    /// <summary>
    /// definition of BuildLog with parameters of .Net value type.
    /// </summary>
	public interface IBuildLog : IBuildLogIdentifier
	{ 

        System.Int64 BuildId { get; set; }


        System.Int32 BuildEventCodeId { get; set; }


        System.String Message { get; set; }


        System.DateTime EventTime { get; set; }

	}

    /// <summary>
    /// a property defined when <see cref="WithEntityContractBuildLog"/> is used in other classes.
    /// </summary>
    /// <typeparam name="T">a type inherits from <see cref="WithEntityContractBuildLog"/></typeparam>
	public interface WithEntityContractBuildLog<T>
        where T : IBuildLog
    {
        /// <summary>
        /// Gets or sets the BuildLog
        /// </summary>
        /// <value>
        /// The BuildLog
        /// </value>
        T BuildLog { get; set; }
    }
}

