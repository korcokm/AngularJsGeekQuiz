using Newtonsoft.Json.Serialization;  // MK - Added JSON library
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace GeekQuiz
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // --- Use camel case for JSON data.
            // --- The CamelCasePropertyNamesContractResolver automatically converts property names to camel case, which is the general convention for property names in JavaScript.
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
