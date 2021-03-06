using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace MSBuildLogsExtended.DALContracts
{
    /// <summary>
    /// There is one method for each entity class, which creates data access layer instance.
    /// </summary>
    public partial interface DataAccessLayerFactoryContract
//        <

//		TDALContractOfBuild, TCollectionOfBuild, TOfBuild, TIdentifierOfBuild


//		, TDALContractOfBuildEventCode, TCollectionOfBuildEventCode, TOfBuildEventCode, TIdentifierOfBuildEventCode


//		, TDALContractOfBuildLog, TCollectionOfBuildLog, TOfBuildLog, TIdentifierOfBuildLog


//		, TDALContractOfSolution, TCollectionOfSolution, TOfSolution, TIdentifierOfSolution


//        >


//            where TDALContractOfBuild : IBuildRepository<TCollectionOfBuild, TOfBuild, TIdentifierOfBuild>
//            where TCollectionOfBuild : IList<TOfBuild>, new()
//            where TOfBuild : MSBuildLogsExtended.EntityContracts.IBuild, new()
//            where TIdentifierOfBuild : MSBuildLogsExtended.EntityContracts.IBuildIdentifier, new()


//            where TDALContractOfBuildEventCode : IBuildEventCodeRepository<TCollectionOfBuildEventCode, TOfBuildEventCode, TIdentifierOfBuildEventCode>
//            where TCollectionOfBuildEventCode : IList<TOfBuildEventCode>, new()
//            where TOfBuildEventCode : MSBuildLogsExtended.EntityContracts.IBuildEventCode, new()
//            where TIdentifierOfBuildEventCode : MSBuildLogsExtended.EntityContracts.IBuildEventCodeIdentifier, new()


//            where TDALContractOfBuildLog : IBuildLogRepository<TCollectionOfBuildLog, TOfBuildLog, TIdentifierOfBuildLog>
//            where TCollectionOfBuildLog : IList<TOfBuildLog>, new()
//            where TOfBuildLog : MSBuildLogsExtended.EntityContracts.IBuildLog, new()
//            where TIdentifierOfBuildLog : MSBuildLogsExtended.EntityContracts.IBuildLogIdentifier, new()


//            where TDALContractOfSolution : ISolutionRepository<TCollectionOfSolution, TOfSolution, TIdentifierOfSolution>
//            where TCollectionOfSolution : IList<TOfSolution>, new()
//            where TOfSolution : MSBuildLogsExtended.EntityContracts.ISolution, new()
//            where TIdentifierOfSolution : MSBuildLogsExtended.EntityContracts.ISolutionIdentifier, new()


    {

        /// <summary>
        /// Creates the DAL instance of MSBuildLogsExtended.DALContracts.IBuildRepository for entity TDALContractOfBuild .
        /// </summary>
        /// <returns>one instance of data access layer class</returns>
        //TDALContractOfBuild CreateDALInstanceOfBuild();
		MSBuildLogsExtended.DALContracts.IBuildRepository CreateDALInstanceOfBuild();


        /// <summary>
        /// Creates the DAL instance of MSBuildLogsExtended.DALContracts.IBuildEventCodeRepository for entity TDALContractOfBuildEventCode .
        /// </summary>
        /// <returns>one instance of data access layer class</returns>
        //TDALContractOfBuildEventCode CreateDALInstanceOfBuildEventCode();
		MSBuildLogsExtended.DALContracts.IBuildEventCodeRepository CreateDALInstanceOfBuildEventCode();


        /// <summary>
        /// Creates the DAL instance of MSBuildLogsExtended.DALContracts.IBuildLogRepository for entity TDALContractOfBuildLog .
        /// </summary>
        /// <returns>one instance of data access layer class</returns>
        //TDALContractOfBuildLog CreateDALInstanceOfBuildLog();
		MSBuildLogsExtended.DALContracts.IBuildLogRepository CreateDALInstanceOfBuildLog();


        /// <summary>
        /// Creates the DAL instance of MSBuildLogsExtended.DALContracts.ISolutionRepository for entity TDALContractOfSolution .
        /// </summary>
        /// <returns>one instance of data access layer class</returns>
        //TDALContractOfSolution CreateDALInstanceOfSolution();
		MSBuildLogsExtended.DALContracts.ISolutionRepository CreateDALInstanceOfSolution();


	}
}