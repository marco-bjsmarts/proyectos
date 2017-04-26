using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //RegisterRoutes(RouteTable.Routes);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

       /* private void RegisterRoutes(RouteCollection routes)
        {
            //solicitud para rest aspi principal
            routes.MapPageRoute("Solicitud", "Api/entities/{tipoSolicitud}('{tableName}')/{tipoConsulta}",
                "~/Api/Entities.aspx");

        }*/
    }
 }
