using System.Web.Http;
using Owin;
using WebApi.Config;

namespace WebApiOwinHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfiguration.Configure(config);
            app.UseWebApi(config);
        }
    }
}
