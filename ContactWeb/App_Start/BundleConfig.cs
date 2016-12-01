using System.Web;
using System.Web.Optimization;

namespace ContactWeb
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/js/lib/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/js/lib/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/js/lib/jquery.datatables.min.js",
                        "~/js/lib/datatables.bootstrap.min.js",
                        "~/js/lib/datatables.colReorder.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/jquery.datatables.min.css",
                      "~/css/jquery.datatables_themeroller.css",
                      "~/css/datatables.bootstrap.min.css",
                      "~/css/colReorder.bootstrap.min.css",
                      "~/css/site.css"));
        }
    }
}
