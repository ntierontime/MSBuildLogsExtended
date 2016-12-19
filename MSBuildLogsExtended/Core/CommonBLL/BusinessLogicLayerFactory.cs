using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLL
{
    /// <summary>
    /// is to factory class to create instances of business layer classes
    /// </summary>
	public partial class BusinessLogicLayerFactory : MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory
    {
        #region Entity related


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.Build"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of BuildService</returns>
        public MSBuildLogsExtended.WcfContracts.IBuildService CreateBLLInstanceOfEntityBuild(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
        {
            return new BuildService(businessLogicLayerContext);
        }


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.BuildEventCode"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of BuildEventCodeService</returns>
        public MSBuildLogsExtended.WcfContracts.IBuildEventCodeService CreateBLLInstanceOfEntityBuildEventCode(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
        {
            return new BuildEventCodeService(businessLogicLayerContext);
        }


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.BuildLog"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of BuildLogService</returns>
        public MSBuildLogsExtended.WcfContracts.IBuildLogService CreateBLLInstanceOfEntityBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
        {
            return new BuildLogService(businessLogicLayerContext);
        }


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.Solution"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of SolutionService</returns>
        public MSBuildLogsExtended.WcfContracts.ISolutionService CreateBLLInstanceOfEntitySolution(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
        {
            return new SolutionService(businessLogicLayerContext);
        }



        #endregion Entity related
    }

    /// <summary>
    /// Singleton of <see cref="BusinessLogicLayerFactory"/>
    /// </summary>
    public class BusinessLogicLayerFactorySingleton
        : Framework.Singleton<BusinessLogicLayerFactory>
    {
    }
}