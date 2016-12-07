using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MSBuildLogsExtended.AspNetMvc40Controller
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
			
            MSBuildLogsExtended.AspNetMvc40Controller.WebApiConfig.Register(GlobalConfiguration.Configuration);
            MSBuildLogsExtended.AspNetMvc40Controller.FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            MSBuildLogsExtended.AspNetMvc40Controller.RouteConfig.RegisterRoutes(RouteTable.Routes);
            MSBuildLogsExtended.AspNetMvc40Controller.BundleConfig.RegisterBundles(BundleTable.Bundles);
            MSBuildLogsExtended.AspNetMvc40Controller.AuthConfig.RegisterAuth();

			GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
			GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(new System.Net.Http.Formatting.QueryStringMapping("json", "true", "application/json"));
			
			Framework.Web.WebFormApplicationApplicationVariables.GetDefault();

			Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactory, MSBuildLogsExtended.CommonBLL.BusinessLogicLayerFactory>();
            Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer, Framework.CommonBLLEntities.BusinessLogicLayerContextContainerCommon>();
            Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<MSBuildLogsExtended.DALContracts.DataAccessLayerFactoryContract, MSBuildLogsExtended.LinqDAL.LinqToSqlDataAccessLayerFactory>();

            Framework.CommonBLLEntities.BusinessLogicLayerMemberShip _BusinessLogicLayerMemberShip = new Framework.CommonBLLEntities.BusinessLogicLayerMemberShip();
            //Framework.Web.WebFormApplicationSessionVariables.BusinessLogicLayerContext = new Framework.CommonBLLEntities.BusinessLogicLayerContext(
            //    _BusinessLogicLayerMemberShip 
            //    , MSBuildLogsExtended.LinqDAL.LinqToSqlDataAccessLayerFactorySingleton.Instance);
            List<Framework.CommonBLLEntities.BusinessLogicLayerContextSetting> _BusinessLogicLayerContextSettingCollection = new List<Framework.CommonBLLEntities.BusinessLogicLayerContextSetting>();
            _BusinessLogicLayerContextSettingCollection.Add(new Framework.CommonBLLEntities.BusinessLogicLayerContextSetting(
				"MSBuildLogsExtended"
				, typeof(Framework.Web.WebFormApplicationSessionVariables)
				, typeof(Framework.CommonBLLEntities.BusinessLogicLayerContext)
				, typeof(MSBuildLogsExtended.LinqDAL.LinqToSqlDataAccessLayerFactory)));
            foreach (Framework.CommonBLLEntities.BusinessLogicLayerContextSetting _BusinessLogicLayerContextSetting in _BusinessLogicLayerContextSettingCollection)
            {
                object[] _Params = new object[] {_BusinessLogicLayerMemberShip };
                object _BusinessLogicLayerContext = Activator.CreateInstance(_BusinessLogicLayerContextSetting.TypeOfBusinessLogicLayerContext, _Params);
                _BusinessLogicLayerContextSetting.TypeOfTargetUser.GetProperty("BusinessLogicLayerContext").SetValue(null, _BusinessLogicLayerContext, null);
            }


            var a = new MSBuildLogsExtended.AspNetMvc40Controller.ApiControllers.BuildApiController();
            ControllerBuilder.Current.DefaultNamespaces.Add("MSBuildLogsExtended.AspNetMvc40Controller.ApiControllers");
        }
    }
}

