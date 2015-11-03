using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using Microsoft.Practices.Unity;

namespace MSBuildLogsExtended.WcfContracts
{
    public static class WcfServiceResolver
    {


        public static MSBuildLogsExtended.WcfContracts.IBuildWcfService ResolveWcfServiceBuild()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory>();
            MSBuildLogsExtended.WcfContracts.IBuildWcfService _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuild(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }



        public static MSBuildLogsExtended.WcfContracts.IBuildEventCodeWcfService ResolveWcfServiceBuildEventCode()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory>();
            MSBuildLogsExtended.WcfContracts.IBuildEventCodeWcfService _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuildEventCode(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }



        public static MSBuildLogsExtended.WcfContracts.IBuildLogWcfService ResolveWcfServiceBuildLog()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory>();
            MSBuildLogsExtended.WcfContracts.IBuildLogWcfService _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuildLog(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }



        public static MSBuildLogsExtended.WcfContracts.ISolutionWcfService ResolveWcfServiceSolution()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory>();
            MSBuildLogsExtended.WcfContracts.ISolutionWcfService _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntitySolution(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }


    }

    public static class WcfServiceResolverAsyn
    {


        public static MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuild ResolveWcfServiceBuild()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn>();
            MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuild _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuild(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }



        public static MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuildEventCode ResolveWcfServiceBuildEventCode()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn>();
            MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuildEventCode _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuildEventCode(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }



        public static MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuildLog ResolveWcfServiceBuildLog()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn>();
            MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuildLog _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntityBuildLog(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }



        public static MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynSolution ResolveWcfServiceSolution()
        {
            Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer _IBusinessLogicLayerContextContainer = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer>();
            Framework.CommonBLLEntities.BusinessLogicLayerContext _BusinessLogicLayerContext = _IBusinessLogicLayerContextContainer.BusinessLogicLayerContext;
            MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn _IBusinessLogicLayerFactory = Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Resolve<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn>();
            MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynSolution _BusinessLogicLayerInstance = _IBusinessLogicLayerFactory.CreateBLLInstanceOfEntitySolution(_BusinessLogicLayerContext);
            return _BusinessLogicLayerInstance;
        }


    }
}