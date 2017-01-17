using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PrelimWQ
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               "Euroqol",
               "Questionnaires/Page1",
               new { controller = "Questionnaires", action = "Page1" }
               );

            routes.MapRoute(
                "EuroqolPage1Save",
                "Questionnaires/Page1Save",
                new { controller = "Questionnaires", action = "Page1Save" }
                );


          

        }
    }
}
