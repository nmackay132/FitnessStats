using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using FitnessStats.Repositories;

namespace WebUI
{
    public class ApplicationBoostrapper
    {
        public ApplicationBoostrapper()
        {
            var builder = RegisterComponents(new ContainerBuilder());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private ContainerBuilder RegisterComponents(ContainerBuilder builder)
        {
            var assembly = typeof (MvcApplication).Assembly;
            builder.RegisterControllers(assembly);
            builder.RegisterType<MongoRepository>();
            return builder;
        }
    }
}