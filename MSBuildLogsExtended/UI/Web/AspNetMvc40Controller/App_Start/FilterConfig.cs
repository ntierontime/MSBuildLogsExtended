using System.Web;
using System.Web.Mvc;

namespace MSBuildLogsExtended.AspNetMvc40Controller
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}