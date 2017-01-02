using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using Microsoft.Practices.Unity;

namespace MSBuildLogsExtended.WcfContracts
{
    public static partial class WcfServiceResolver
    {


        public static MSBuildLogsExtended.WcfContracts.IBuildService ResolveWcfServiceBuild()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory>();
            MSBuildLogsExtended.WcfContracts.IBuildService _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuild(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }



        public static MSBuildLogsExtended.WcfContracts.IBuildEventCodeService ResolveWcfServiceBuildEventCode()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory>();
            MSBuildLogsExtended.WcfContracts.IBuildEventCodeService _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuildEventCode(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }



        public static MSBuildLogsExtended.WcfContracts.IBuildLogService ResolveWcfServiceBuildLog()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory>();
            MSBuildLogsExtended.WcfContracts.IBuildLogService _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuildLog(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }



        public static MSBuildLogsExtended.WcfContracts.ISolutionService ResolveWcfServiceSolution()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory>();
            MSBuildLogsExtended.WcfContracts.ISolutionService _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntitySolution(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }


    }

    public static partial class WcfServiceResolverAsyn
    {


        public static MSBuildLogsExtended.WcfContracts.IBuildServiceAsyn ResolveWcfServiceBuild()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn>();
            MSBuildLogsExtended.WcfContracts.IBuildServiceAsyn _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuild(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }



        public static MSBuildLogsExtended.WcfContracts.IBuildEventCodeServiceAsyn ResolveWcfServiceBuildEventCode()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn>();
            MSBuildLogsExtended.WcfContracts.IBuildEventCodeServiceAsyn _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuildEventCode(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }



        public static MSBuildLogsExtended.WcfContracts.IBuildLogServiceAsyn ResolveWcfServiceBuildLog()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn>();
            MSBuildLogsExtended.WcfContracts.IBuildLogServiceAsyn _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuildLog(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }



        public static MSBuildLogsExtended.WcfContracts.ISolutionServiceAsyn ResolveWcfServiceSolution()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn>();
            MSBuildLogsExtended.WcfContracts.ISolutionServiceAsyn _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntitySolution(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }


    }

}