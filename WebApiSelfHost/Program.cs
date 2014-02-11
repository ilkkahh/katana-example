using System;
using System.Web.Http;
using Microsoft.Owin.Hosting;
using Owin;
using WebApi.Config;

namespace WebApiSelfHost
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string BaseUrl = "http://localhost:56000/";

            using (WebApp.Start(BaseUrl, appBuilder =>
                                         {
                                             var config = new HttpConfiguration();
                                             WebApiConfiguration.Configure(config);
                                             appBuilder.UseWebApi(config);
                                         }))
            {
                Console.WriteLine("Listening in {0}", BaseUrl);
                Console.WriteLine("Press Enter to quit.");
                Console.ReadKey();                
            }
        }
    }
}
