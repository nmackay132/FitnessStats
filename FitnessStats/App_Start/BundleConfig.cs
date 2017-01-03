using System.Web.Optimization;

namespace FitnessStats
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/dependencies").Include(
                "~/node_modules/jquery/dist/jquery.min.js",
                "~/node_modules/datatables.net/js/jquery.dataTables.js",
                "~/node_modules/material-design-lite/material.min.js",
                "~/node_modules/knockout/build/output/knockout-latest.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/node_modules/material-design-lite/material.min.css",
                      "~/node_modules/datatables.net-dt/css/jquery.dataTables.css",
                      "~/Content/css/styles.css"));

            bundles.Add(new ScriptBundle("~/bundles/require").Include("~/node_modules/requirejs/require.js"));
        }
    }
}
