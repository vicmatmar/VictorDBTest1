using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VictorDBTest1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            using (App_Data.ManufacturingStore_v2Entities cx = new App_Data.ManufacturingStore_v2Entities())
            {
                var ps = cx.Products.ToArray();
                string s = "";
                foreach(var p in ps)
                {
                    s += p.Name;
                }
            }

                routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
