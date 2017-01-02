using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSBuildLogsExtended.WcfClientBLL
{
    /// <summary>
    /// is to factory class to create instances of business layer classes
    /// </summary>
    public class WcfClientFactory : MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory
    {
        #region Entity related


        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.Build"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildLogsExtended.WcfContracts.IBuildService</returns>
        public MSBuildLogsExtended.WcfContracts.IBuildService CreateBLLInstanceOfEntityBuild(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
			return new MSBuildLogsExtended.WcfClientBLL.WcfClientEntityBuild();
		}



        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.BuildEventCode"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildLogsExtended.WcfContracts.IBuildEventCodeService</returns>
        public MSBuildLogsExtended.WcfContracts.IBuildEventCodeService CreateBLLInstanceOfEntityBuildEventCode(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
			return new MSBuildLogsExtended.WcfClientBLL.WcfClientEntityBuildEventCode();
		}



        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.BuildLog"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildLogsExtended.WcfContracts.IBuildLogService</returns>
        public MSBuildLogsExtended.WcfContracts.IBuildLogService CreateBLLInstanceOfEntityBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
			return new MSBuildLogsExtended.WcfClientBLL.WcfClientEntityBuildLog();
		}



        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.Solution"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildLogsExtended.WcfContracts.ISolutionService</returns>
        public MSBuildLogsExtended.WcfContracts.ISolutionService CreateBLLInstanceOfEntitySolution(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
			return new MSBuildLogsExtended.WcfClientBLL.WcfClientEntitySolution();
		}




        #endregion Entity related
    }

    /// <summary>
    /// Singleton of <see cref="WcfClientFactory"/>
    /// </summary>
    public class WcfClientFactorySingleton
        : Framework.Singleton<WcfClientFactory>
    {
    }

    /// <summary>
    /// is to factory class to create instances of business layer classes
    /// </summary>
    public class WcfClientFactoryAsyn : MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn
    {

#if NETFX_CORE && DEBUG
//  for WinRT/NETFX_CORE debug, because no app.config file

        public const string Url_MSBuildLogsExtended_WcfClientBLL_WcfClientEntityAsynBuild = "http://localhost:10805/WcfMarkupBuild.svc";    


        public const string Url_MSBuildLogsExtended_WcfClientBLL_WcfClientEntityAsynBuildEventCode = "http://localhost:10805/WcfMarkupBuildEventCode.svc";    


        public const string Url_MSBuildLogsExtended_WcfClientBLL_WcfClientEntityAsynBuildLog = "http://localhost:10805/WcfMarkupBuildLog.svc";    


        public const string Url_MSBuildLogsExtended_WcfClientBLL_WcfClientEntityAsynSolution = "http://localhost:10805/WcfMarkupSolution.svc";    


#elif NETFX_CORE
// for WinRT/NETFX_CORE release, because no app.config file

        public const string Url_MSBuildLogsExtended_WcfClientBLL_WcfClientEntityAsynBuild = "http://localhost:10805/WcfMarkupBuild.svc";    


        public const string Url_MSBuildLogsExtended_WcfClientBLL_WcfClientEntityAsynBuildEventCode = "http://localhost:10805/WcfMarkupBuildEventCode.svc";    


        public const string Url_MSBuildLogsExtended_WcfClientBLL_WcfClientEntityAsynBuildLog = "http://localhost:10805/WcfMarkupBuildLog.svc";    


        public const string Url_MSBuildLogsExtended_WcfClientBLL_WcfClientEntityAsynSolution = "http://localhost:10805/WcfMarkupSolution.svc";    

    
#endif

        #region Entity related

        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.Build"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildLogsExtended.WcfContracts.IBuildServiceAsyn</returns>
        public MSBuildLogsExtended.WcfContracts.IBuildServiceAsyn CreateBLLInstanceOfEntityBuild(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
#if NETFX_CORE
// for WinRT/NETFX_CORE release, because no app.config file, initialize WcfClient with Url
            return new MSBuildLogsExtended.WcfClientBLL.WcfClientEntityAsynBuild(new System.ServiceModel.BasicHttpBinding(), new System.ServiceModel.EndpointAddress(Url_MSBuildLogsExtended_WcfClientBLL_WcfClientEntityAsynBuild));
#else
			return new MSBuildLogsExtended.WcfClientBLL.WcfClientEntityAsynBuild();
#endif
		}



        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.BuildEventCode"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildLogsExtended.WcfContracts.IBuildEventCodeServiceAsyn</returns>
        public MSBuildLogsExtended.WcfContracts.IBuildEventCodeServiceAsyn CreateBLLInstanceOfEntityBuildEventCode(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
#if NETFX_CORE
// for WinRT/NETFX_CORE release, because no app.config file, initialize WcfClient with Url
            return new MSBuildLogsExtended.WcfClientBLL.WcfClientEntityAsynBuildEventCode(new System.ServiceModel.BasicHttpBinding(), new System.ServiceModel.EndpointAddress(Url_MSBuildLogsExtended_WcfClientBLL_WcfClientEntityAsynBuildEventCode));
#else
			return new MSBuildLogsExtended.WcfClientBLL.WcfClientEntityAsynBuildEventCode();
#endif
		}



        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.BuildLog"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildLogsExtended.WcfContracts.IBuildLogServiceAsyn</returns>
        public MSBuildLogsExtended.WcfContracts.IBuildLogServiceAsyn CreateBLLInstanceOfEntityBuildLog(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
#if NETFX_CORE
// for WinRT/NETFX_CORE release, because no app.config file, initialize WcfClient with Url
            return new MSBuildLogsExtended.WcfClientBLL.WcfClientEntityAsynBuildLog(new System.ServiceModel.BasicHttpBinding(), new System.ServiceModel.EndpointAddress(Url_MSBuildLogsExtended_WcfClientBLL_WcfClientEntityAsynBuildLog));
#else
			return new MSBuildLogsExtended.WcfClientBLL.WcfClientEntityAsynBuildLog();
#endif
		}



        /// <summary>
        /// Creates the BLL instance of entity <see cref="MSBuildLogsExtended.Solution"/> tables for change notification.
        /// </summary>
        /// <param name="businessLogicLayerContext">The business logic layer context.</param>
        /// <returns>Instance of MSBuildLogsExtended.WcfContracts.ISolutionServiceAsyn</returns>
        public MSBuildLogsExtended.WcfContracts.ISolutionServiceAsyn CreateBLLInstanceOfEntitySolution(Framework.CommonBLLEntities.BusinessLogicLayerContext businessLogicLayerContext)
		{
#if NETFX_CORE
// for WinRT/NETFX_CORE release, because no app.config file, initialize WcfClient with Url
            return new MSBuildLogsExtended.WcfClientBLL.WcfClientEntityAsynSolution(new System.ServiceModel.BasicHttpBinding(), new System.ServiceModel.EndpointAddress(Url_MSBuildLogsExtended_WcfClientBLL_WcfClientEntityAsynSolution));
#else
			return new MSBuildLogsExtended.WcfClientBLL.WcfClientEntityAsynSolution();
#endif
		}



        #endregion Entity related
    }

    /// <summary>
    /// Singleton of <see cref="WcfClientFactoryAsyn"/>
    /// </summary>
    public class WcfClientFactoryAsynSingleton
        : Framework.Singleton<WcfClientFactoryAsyn>
    {
    }
}