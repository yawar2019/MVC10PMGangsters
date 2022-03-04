using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC10PMGangsters
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();//Enable Attribute based Routing 

            routes.MapRoute(
                name: "Default1",
                url: "PistaHouse/Cake",
                defaults: new { controller = "New", action = "Index3", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Default2",
               url: "Agra/TajMahal",
               defaults: new { controller = "New", action = "Index3", id = UrlParameter.Optional }
           );


            routes.MapRoute(
   name: "Default",
   url: "{controller}/{action}/{id}",
   defaults: new { controller = "New", action = "HtmlHelperExample", id = UrlParameter.Optional }
);
        }
    }
}
