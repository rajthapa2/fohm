using System.Web;
using System.Web.Optimization;

namespace trail
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/libs/*.js"));
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/models/*.js"));
        }
    }
}
