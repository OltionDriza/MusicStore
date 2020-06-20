using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MusicStore.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null,
            "",
            new
            {
                controller = "Album",
                action = "List",
                genre = (string)null,
                page = 1
            }
);

            routes.MapRoute(
                null,
                "Page{page}",
                new { Controller = "Album", action = "List", genre = (string)null },
                new { page = @"\d+" }
                );

            routes.MapRoute(null,
                "{genre}",
                new { controller = "Album", action = "List", page = 1 }
            );


            routes.MapRoute(null,
                "{genre}/Page{page}",
                new { controller = "Album", action = "List" },
                new { page = @"\d+" }
                );
            routes.MapRoute(null, "{controller}/{action}");


            routes.MapRoute(
            name: null,
            url: "Page{page}",
            defaults: new { Controller = "Store", action = "AlbumList" }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
