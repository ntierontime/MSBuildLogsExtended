using System.Web;
using System.Web.Optimization;

namespace MSBuildLogsExtended.AspNetMvc50AngularSPA
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Clear();

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-cookies.js",
                "~/Scripts/angular-sanitize.js",
                "~/Scripts/angular-translate.js",
                //"~/Scripts/angular-translate-loader-static-files.js",
                //"~/Scripts/angular-translate-loader-url.js",
                "~/Scripts/angular-translate-loader-partial.js",
                "~/Scripts/angular-translate-storage-cookie.js",
                "~/Scripts/angular-translate-storage-local.js",
                "~/Scripts/angular-ui-router.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.js"
                ));
            
            bundles.Add(new ScriptBundle("~/bundles/angularModule")
                // should add per entity
                .IncludeDirectory("~/www/controllers", "*.js")
                .IncludeDirectory("~/www/factories", "*.js")
                .Include("~/www/ApplicationModule.js")
                );

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // css
            bundles.Add(new ScriptBundle("~/container/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/ui-bootstrap-csp.css",
                "~/Content/Site.css"
            ));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}

