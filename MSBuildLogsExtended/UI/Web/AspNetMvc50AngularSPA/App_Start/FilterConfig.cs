using System.Web;
using System.Web.Mvc;

namespace MSBuildLogsExtended.AspNetMvc50AngularSPA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}