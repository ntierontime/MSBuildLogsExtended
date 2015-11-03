using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.CommonBLL
{
    /// <summary>
    /// is to factory class to create instances of business layer classes
    /// </summary>
	public class BusinessLogicLayerFactory : MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory
    {
        #region Entity related


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.Build"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of BusinessLogicLayerEntityBuild</returns>
        public MSBuildLogsExtended.WcfContracts.IBuildWcfService CreateBLLInstanceOfEntityBuild(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
        {
            return new BusinessLogicLayerEntityBuild(businessLogicLayerContext);
        }


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.BuildEventCode"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of BusinessLogicLayerEntityBuildEventCode</returns>
        public MSBuildLogsExtended.WcfContracts.IBuildEventCodeWcfService CreateBLLInstanceOfEntityBuildEventCode(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
        {
            return new BusinessLogicLayerEntityBuildEventCode(businessLogicLayerContext);
        }


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.BuildLog"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of BusinessLogicLayerEntityBuildLog</returns>
        public MSBuildLogsExtended.WcfContracts.IBuildLogWcfService CreateBLLInstanceOfEntityBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
        {
            return new BusinessLogicLayerEntityBuildLog(businessLogicLayerContext);
        }


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.Solution"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of BusinessLogicLayerEntitySolution</returns>
        public MSBuildLogsExtended.WcfContracts.ISolutionWcfService CreateBLLInstanceOfEntitySolution(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
        {
            return new BusinessLogicLayerEntitySolution(businessLogicLayerContext);
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