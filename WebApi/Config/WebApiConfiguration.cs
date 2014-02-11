using System.Web.Http;

namespace WebApi.Config
{
    public static class WebApiConfiguration
    {
        public static void Configure(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional}
                );

           config.DependencyResolver = new WebApiDependencyResolver();
        }
    }
}
