using System;
namespace MSBuildLogsExtended.WcfContracts
{
    public partial interface IBusinessLogicLayerFactory
    {


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.Build"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IBuildService</returns>
        IBuildService CreateBLLInstanceOfEntityBuild(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.BuildEventCode"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IBuildEventCodeService</returns>
        IBuildEventCodeService CreateBLLInstanceOfEntityBuildEventCode(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.BuildLog"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IBuildLogService</returns>
        IBuildLogService CreateBLLInstanceOfEntityBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.Solution"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of ISolutionService</returns>
        ISolutionService CreateBLLInstanceOfEntitySolution(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);



    }

    public partial interface IBusinessLogicLayerFactoryAsyn
    {

        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.Build"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IBuildServiceAsyn</returns>
        IBuildServiceAsyn CreateBLLInstanceOfEntityBuild(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.BuildEventCode"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IBuildEventCodeServiceAsyn</returns>
        IBuildEventCodeServiceAsyn CreateBLLInstanceOfEntityBuildEventCode(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.BuildLog"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of IBuildLogServiceAsyn</returns>
        IBuildLogServiceAsyn CreateBLLInstanceOfEntityBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.Solution"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of ISolutionServiceAsyn</returns>
        ISolutionServiceAsyn CreateBLLInstanceOfEntitySolution(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext);



    }
}