using System.Web.Optimization;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Conventions;
using Nancy.TinyIoc;

namespace NancyAspNETWebOptimizationExample
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            nancyConventions.StaticContentsConventions
                .Add(StaticContentConventionBuilder.AddDirectory("/js"));

            nancyConventions.StaticContentsConventions
                .Add(StaticContentConventionBuilder.AddDirectory("/css"));
        }

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            var scriptBundle = new ScriptBundle("~/js")
                .IncludeDirectory("~/Content/js/", "*.js");

            var styleBundle = new StyleBundle("~/css")
                .IncludeDirectory("~/Content/css", "*.css");

            BundleTable.Bundles.Add(scriptBundle);
            BundleTable.Bundles.Add(styleBundle);

            BundleTable.EnableOptimizations = true;
        }
    }
}