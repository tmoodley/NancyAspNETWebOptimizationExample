using Nancy;

namespace NancyAspNETWebOptimizationExample
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => { return View["Views/Home"]; };
        }
    }
}