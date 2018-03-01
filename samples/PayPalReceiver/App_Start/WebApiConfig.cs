using System.Net;
using System.Web.Http;

namespace PayPalReceiver
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Initialize PayPal WebHook receiver
            config.InitializeReceivePaypalWebHooks();
        }
    }
}
