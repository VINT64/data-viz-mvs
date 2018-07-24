using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace dataviz
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
                name: "he",
                url: "services/dummyRequest",
                defaults: new { controller = "Request", action = "dummyRequest" }
            );
            routes.MapRoute(
                name: "404",
                url: "{*anything}",
                defaults: new { controller = "NotFound", action = "PageNotFound" }
            );
            

        }
    }
}