using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PruebaMvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
				//defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
				//defaults: new { controller = "Consulta", action = "Mostrar", id = UrlParameter.Optional }
				//defaults: new { controller = "AgregarFormulario", action = "Agregar", id = UrlParameter.Optional }
				//defaults: new { controller = "Inicio", action = "Inicio", id = UrlParameter.Optional }
				defaults: new { controller = "Autenticacion", action = "Login", id = UrlParameter.Optional }
			);
        }
    }
}
