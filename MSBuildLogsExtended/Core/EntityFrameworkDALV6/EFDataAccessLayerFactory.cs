using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MSBuildLogsExtended.EntityFrameworkDAL
{
    /// <summary>
    /// a factory class, can create all data access layer class instances for each entity.
    /// </summary>
    public class EFDataAccessLayerFactory
        : MSBuildLogsExtended.DALContracts.DataAccessLayerFactoryContract
	{
        #region constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public EFDataAccessLayerFactory()
        {
        }

        #endregion constructors

		#region Entity related


        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildLogsExtended.DALContracts.IBuildRepository"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DALContracts.IBuildRepository"/>.</returns>
        public MSBuildLogsExtended.DALContracts.IBuildRepository CreateDALInstanceOfBuild()
        {
            return new MSBuildLogsExtended.EntityFrameworkDAL.BuildRepository(new MSBuildLogsExtended.EntityFrameworkContext.MSBuildLogsExtendedEntities());
        }



        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildLogsExtended.DALContracts.IBuildEventCodeRepository"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DALContracts.IBuildEventCodeRepository"/>.</returns>
        public MSBuildLogsExtended.DALContracts.IBuildEventCodeRepository CreateDALInstanceOfBuildEventCode()
        {
            return new MSBuildLogsExtended.EntityFrameworkDAL.BuildEventCodeRepository(new MSBuildLogsExtended.EntityFrameworkContext.MSBuildLogsExtendedEntities());
        }



        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildLogsExtended.DALContracts.IBuildLogRepository"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DALContracts.IBuildLogRepository"/>.</returns>
        public MSBuildLogsExtended.DALContracts.IBuildLogRepository CreateDALInstanceOfBuildLog()
        {
            return new MSBuildLogsExtended.EntityFrameworkDAL.BuildLogRepository(new MSBuildLogsExtended.EntityFrameworkContext.MSBuildLogsExtendedEntities());
        }



        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildLogsExtended.DALContracts.ISolutionRepository"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DALContracts.ISolutionRepository"/>.</returns>
        public MSBuildLogsExtended.DALContracts.ISolutionRepository CreateDALInstanceOfSolution()
        {
            return new MSBuildLogsExtended.EntityFrameworkDAL.SolutionRepository(new MSBuildLogsExtended.EntityFrameworkContext.MSBuildLogsExtendedEntities());
        }



		#endregion Entity related
    }

    /// <summary>
    /// singlton class of <see cref="EFDataAccessLayerFactory"/>
    /// </summary>
    public class EFDataAccessLayerFactorySingleton : Framework.Singleton<EFDataAccessLayerFactory>
    {
    }
}