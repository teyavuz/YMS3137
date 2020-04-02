using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVCCustomTheme.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundle/js").Include(
                "~/Content/js/jquery.js",
                "~/Content/js/jquery-1.8.3.min.js",
                "~/Content/js/bootstrap.min.js",
                "~/Content/ js/jquery.dcjqaccordion.2.7.js",
                "~/Content/js/jquery.scrollTo.min.js",
                "~/Content/js/jquery.nicescroll.js",
                "~/Content/js/jquery.sparkline.js",
                "~/Content/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.js",
                "~/Content/js/owl.carousel.js",
                "~/Content/js/respond.min.js",
                "~/Content/js/jquery.dcjqaccordion.2.7.js",
                "~/Content/js/common-scripts.js",
                "~/Content/js/sparkline-chart.js",
                "~/Content/js/easy-pie-chart.js",
                "~/Content/js/count.js"
                ));
            bundles.Add(new StyleBundle("~/bundle/css").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/bootstrap-reset.css",
                "~/Content/assets/font-awesome/css/font-awesome.css",
                  "~/Content/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.css",
                  "~/Content/css/style.css",
                  "~/Content/css/style-responsive.css"
                ));
        }
    }
}