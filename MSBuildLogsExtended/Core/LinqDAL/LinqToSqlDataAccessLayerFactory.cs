using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MSBuildLogsExtended.LinqDAL
{
    /// <summary>
    /// a factory class, can create all data access layer class instances for each entity.
    /// </summary>
    public class LinqToSqlDataAccessLayerFactory
        : MSBuildLogsExtended.DALContracts.DataAccessLayerFactoryContract
	{
        #region properties

        /// <summary>
        /// connection string to connect a database
        /// </summary>
        public string ConnectionString { get; set; }

        #endregion properties

        #region constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public LinqToSqlDataAccessLayerFactory()
        {
            this.ConnectionString = ConfigurationManager.ConnectionStrings["MSBuildLogsExtended"].ConnectionString;
        }


        /// <summary>
        /// constructor with connection string as paramter
        /// </summary>
        /// <param name="connectionString">database connection string</param>
		public LinqToSqlDataAccessLayerFactory(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        #endregion constructors

		#region Entity related


        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildLogsExtended.DALContracts.IBuildRepository"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DALContracts.IBuildRepository"/>.</returns>
        public MSBuildLogsExtended.DALContracts.IBuildRepository CreateDALInstanceOfBuild()
        {
            return new MSBuildLogsExtended.LinqDAL.BuildRepository(new MSBuildLogsExtended.LinqToSqlContexts.MSBuildLogsExtendedContext(this.ConnectionString));
        }



        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildLogsExtended.DALContracts.IBuildEventCodeRepository"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DALContracts.IBuildEventCodeRepository"/>.</returns>
        public MSBuildLogsExtended.DALContracts.IBuildEventCodeRepository CreateDALInstanceOfBuildEventCode()
        {
            return new MSBuildLogsExtended.LinqDAL.BuildEventCodeRepository(new MSBuildLogsExtended.LinqToSqlContexts.MSBuildLogsExtendedContext(this.ConnectionString));
        }



        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildLogsExtended.DALContracts.IBuildLogRepository"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DALContracts.IBuildLogRepository"/>.</returns>
        public MSBuildLogsExtended.DALContracts.IBuildLogRepository CreateDALInstanceOfBuildLog()
        {
            return new MSBuildLogsExtended.LinqDAL.BuildLogRepository(new MSBuildLogsExtended.LinqToSqlContexts.MSBuildLogsExtendedContext(this.ConnectionString));
        }



        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildLogsExtended.DALContracts.ISolutionRepository"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildLogsExtended.DALContracts.ISolutionRepository"/>.</returns>
        public MSBuildLogsExtended.DALContracts.ISolutionRepository CreateDALInstanceOfSolution()
        {
            return new MSBuildLogsExtended.LinqDAL.SolutionRepository(new MSBuildLogsExtended.LinqToSqlContexts.MSBuildLogsExtendedContext(this.ConnectionString));
        }



		#endregion Entity related
    }

    /// <summary>
    /// singlton class of <see cref="LinqToSqlDataAccessLayerFactory"/>
    /// </summary>
    public class LinqToSqlDataAccessLayerFactorySingleton : Framework.Singleton<LinqToSqlDataAccessLayerFactory>
    {
    }
}