using Autofac;
using Autofac.Integration.Mvc;
using SmartBusinessLogic.Services;
using SmartDAL;
using SmartModel.Entities;
using System.Web.Mvc;

namespace SmartApplication.Utilities
{
    abstract public class AutofacConfig
    {
        static public void Config()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<SmartContext>().InstancePerLifetimeScope();
            builder.RegisterType<GenericRepository<Trial>>().As<IGenericRepository<Trial>>().InstancePerLifetimeScope();
            builder.RegisterType<TrialService>().As<ITrialService>().InstancePerLifetimeScope();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
