using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCCustomTheme
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Product",
               url: "{ProductName}-p-{ProductId}",
               defaults: new
               {
                   controller = "Product",
                   action = "Details",
                   ProductName = UrlParameter.Optional,
                   ProductId = UrlParameter.Optional

               }
               );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

           
        }
    }
}
//localhost:1384/Product/Details/Chai-p-1
//localhost:1384/Home/Index