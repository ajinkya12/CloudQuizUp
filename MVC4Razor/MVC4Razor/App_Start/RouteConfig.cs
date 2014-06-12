using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC4Razor
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }, 
                            new String[] { "MVC4Razor.Controllers" }
            );
            routes.MapRoute(
                "Aspx", 
                "{*.aspx}", 
                new String [] {"MVC4Razor"}
                );
            routes.MapRoute(
                    "PersonRoute",
                    "{controller}/{action}/{tags}",
                    new { controller = "Person", action = "Index", tags = "" }
                    );
        }
    }
}