using System.Web.Mvc;

namespace MSBuildLogsExtended.AspNetMvc40Rasor.Area.AreaName
{
    public class AreaNameAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AreaName";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AreaName_default",
                "AreaName/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new { controller = MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.UrlStrings.AreaRouteConstraint },
                new[] { MSBuildLogsExtended.AspNetMvc40Rasor.Helpers.UrlStrings.AreaNamespace }
            );
        }
    }
}

