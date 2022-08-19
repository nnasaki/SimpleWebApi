using System.Web.Http;
using Sitecore.Pipelines;

namespace SimpleWebApi.Pipelines
{
    public class RegisterHttpRoutes
    {
        public void Process(PipelineArgs args)
        {
            GlobalConfiguration.Configure(Configure);
        }
        protected void Configure(HttpConfiguration configuration)
        {
            var routes = configuration.Routes;
            routes.MapHttpRoute("SimpleWebApi.stats", "api/simplewebapi/stats", new
            {
                controller = "SimpleWebApi",
                action = "Stats"
            });

        }
    }
}