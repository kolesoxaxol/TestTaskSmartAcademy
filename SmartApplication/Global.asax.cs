using Autofac;
using Autofac.Integration.Mvc;
using SmartApplication.Utilities;
using SmartBusinessLogic.Services;
using SmartDAL;
using SmartModel.Entities;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SmartApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            AutofacConfig.Config();
            Database.SetInitializer(new SmartContextDbInitializer());
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
