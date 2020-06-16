using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CTS.Musicas.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Rota personalizada para pesquisa de album por nome
            routes.MapRoute(
                name: "PesquisaAlbuns",
                url: "Albuns/PesquisaPorNome/{pesquisa}",
                defaults: new { Controller = "Albuns", action = "FiltrarPorNome", pesquisa = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
