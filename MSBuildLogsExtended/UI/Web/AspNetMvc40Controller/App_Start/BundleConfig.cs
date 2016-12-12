using System.Web;
using System.Web.Optimization;

namespace MSBuildLogsExtended.AspNetMvc40Controller
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Clear();

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Scripts/jquery-{version}.js"
                ,
                "~/Scripts/jquery.validate-{version}.js"
                ,
                "~/Scripts/jquery.unobtrusive*"
                ,
                "~/Scripts/bootstrap.js"
                ,
                "~/Scripts/respond.js"
                ,
                "~/Scripts/bootstrap-datepicker.js"
                ,
                "~/Scripts/bootbox-{version}.js"
                ,
                "~/Scripts/knockout-{version}.js"
                ,
                "~/Scripts/moment*"
                ,
                "~/Scripts/jrate.js"
                ,
                "~/Scripts/dataTables/jquery.dataTables.js"
                ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css"
                , "~/Content/bootstrap-datepicker.css"
                , "~/Content/bootstrap-theme.css"
                , "~/Content/DataTables/css/jquery.dataTables.css"
                , "~/Content/site.css"
                ));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Scripts/jquery-ui-{version}.js",
            //            "~/Scripts/galleria-{version}.js",
            //            "~/Scripts/jRate.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.unobtrusive*",
            //            "~/Scripts/jquery.validate*"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryvalidate").Include(
            //           "~/Scripts/jquery.validate.min.js"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

    //        bundles.Add(new StyleBundle("~/Content/css").Include(
    //            "~/Content/site.css"
    //            , "~/Content/DataTables-1.9.4/media/css/jquery.dataTables.css"
    //            , "~/Content/bootstrap.css"
    //            , "~/Content/bootstrap-datepicker.css"
    //            , "~/Content/bootstrap-responsive.css"
    //            , "~/Content/bootstrap-theme.css"
				//, "~/Content/galleria.classic.css"
				//));

    //        bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
    //                    "~/Content/themes/base/jquery.ui.core.css",
    //                    "~/Content/themes/base/jquery.ui.resizable.css",
    //                    "~/Content/themes/base/jquery.ui.selectable.css",
    //                    "~/Content/themes/base/jquery.ui.accordion.css",
    //                    "~/Content/themes/base/jquery.ui.autocomplete.css",
    //                    "~/Content/themes/base/jquery.ui.button.css",
    //                    "~/Content/themes/base/jquery.ui.dialog.css",
    //                    "~/Content/themes/base/jquery.ui.slider.css",
    //                    "~/Content/themes/base/jquery.ui.tabs.css",
    //                    "~/Content/themes/base/jquery.ui.datepicker.css",
    //                    "~/Content/themes/base/jquery.ui.progressbar.css",
    //                    "~/Content/themes/base/jquery.ui.theme.css"));

            //// knockoutjs
            //bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
            //    "~/Scripts/knockout-{version}.js"));

            //// dataTables.
            //bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
            //    "~/Scripts/DataTables-1.9.4/media/js/jquery.dataTables.js",
            //    "~/Scripts/DataTables-1.9.4/extras/ColReorder/media/js/ColReorder.min.js",
            //    "~/Scripts/DataTables-1.9.4/extras/ColVis/media/js/ColVis.min.js",
            //    //"~/Scripts/DataTables-1.9.4/ZeroClipboard.js",
            //    //"~/Scripts/DataTables-1.9.4/TableTools.min.js",
            //    "~/Scripts/jquery.dataTables.editable.js",
            //    "~/Scripts/jquery.jeditable.js"
            //));

            //// bootstrap + bootbox
            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //    "~/Scripts/bootstrap.js",
            //    "~/Scripts/bootstrap-datepicker.js",
            //    "~/Scripts/bootbox.js"
            //));
        }
    }
}

