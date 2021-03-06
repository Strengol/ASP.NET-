﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Raid",
                url: "Raid/{id}",
                defaults: new { controller = "Raid", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Details",
                url: "Details/{id}",
                defaults: new { controller = "Raid", action = "Details", id = UrlParameter.Optional },
                constraints: new { id=@"\d+"} 
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
