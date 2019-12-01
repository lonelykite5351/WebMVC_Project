using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace lonelykite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //自訂URL-呼叫MapMvcAttributeRoutes方法(建議使用)
            routes.MapMvcAttributeRoutes();


            //自訂URL
            /*
            routes.MapRoute(
                name: "MoviesByReleaseDate",
                url: "movies/released/{year}/{month}",
                defaults: new { controller = "Movies", action = "ByReleaseDate" },
                new { year = @"\d{4}", month = @"\d{2}" }   // 規定變數字元，month4月的話要打04才會導向正確頁面
                );
            */

            routes.MapRoute(
                name: "Default",

                // 預設導向的URL形式
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
