using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _75_MVC_Helper
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Eğer url de textbox görürsen TextBox controllerın TextBox actionına git.!!
            routes.MapRoute(name: "customer", url: "textbox", defaults: new { controller = "TextBox", action = "TextBox" });

            routes.MapRoute(name: "customer-page", url: "customer/{id}", defaults: new { controller = "Customer", Action = "index", id = UrlParameter.Optional });

            //default route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }//opsiyonel olarak belirtilmezse site id olmadan gelmez.
            );
        }
    }
}
