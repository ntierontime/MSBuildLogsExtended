using System;
//using System.Configuration;
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
        /// method to create an data access layer class instance of <see cref="MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractBuild"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractBuild"/>.</returns>
        public MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractBuild CreateDALInstanceOfBuild()
        {
            return new MSBuildLogsExtended.EntityFrameworkDAL.EFDataAccessLayerEntityBuild(new MSBuildLogsExtended.EntityFrameworkContext.MSBuildLogsExtendedEntities(new Microsoft.EntityFrameworkCore.DbContextOptions<EntityFrameworkContext.MSBuildLogsExtendedEntities>()));
        }



        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractBuildEventCode"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractBuildEventCode"/>.</returns>
        public MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractBuildEventCode CreateDALInstanceOfBuildEventCode()
        {
            return new MSBuildLogsExtended.EntityFrameworkDAL.EFDataAccessLayerEntityBuildEventCode(new MSBuildLogsExtended.EntityFrameworkContext.MSBuildLogsExtendedEntities(new Microsoft.EntityFrameworkCore.DbContextOptions<EntityFrameworkContext.MSBuildLogsExtendedEntities>()));
        }



        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractBuildLog"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractBuildLog"/>.</returns>
        public MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractBuildLog CreateDALInstanceOfBuildLog()
        {
            return new MSBuildLogsExtended.EntityFrameworkDAL.EFDataAccessLayerEntityBuildLog(new MSBuildLogsExtended.EntityFrameworkContext.MSBuildLogsExtendedEntities(new Microsoft.EntityFrameworkCore.DbContextOptions<EntityFrameworkContext.MSBuildLogsExtendedEntities>()));
        }



        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractSolution"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractSolution"/>.</returns>
        public MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractSolution CreateDALInstanceOfSolution()
        {
            return new MSBuildLogsExtended.EntityFrameworkDAL.EFDataAccessLayerEntitySolution(new MSBuildLogsExtended.EntityFrameworkContext.MSBuildLogsExtendedEntities(new Microsoft.EntityFrameworkCore.DbContextOptions<EntityFrameworkContext.MSBuildLogsExtendedEntities>()));
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