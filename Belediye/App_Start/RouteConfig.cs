using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Belediye
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "About",
                url: "hakkimizda", // uzantiyi direk belirtebiliyoruz.
                defaults: new { controller = "About", action = "Index"}
            );

            routes.MapRoute(
                name: "Blog",
                url: "blog",
                defaults: new { controller = "Blog", action = "Index"}
            );

            routes.MapRoute(
                name: "Contact",
                url: "iletisim",
                defaults: new { controller = "Contact", action = "Index" }
            );

            // Uzantı belirleme  Bu EN ALTTA OLMAZSA DİĞERLERİNİ DE OTOMATİK AYARLIYOR.
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



        }
    }
}
