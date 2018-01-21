﻿using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using FitnessStats.Clients;
using FitnessStats.Integration;
using FitnessStats.Repositories;
using FitnessStats.Services;

namespace WebUI
{
    public class ApplicationBoostrapper
    {
        public ApplicationBoostrapper()
        {
            var builder = RegisterComponents(new ContainerBuilder());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private ContainerBuilder RegisterComponents(ContainerBuilder builder)
        {
            var assembly = typeof (MvcApplication).Assembly;
            builder.RegisterControllers(assembly);
            builder.RegisterApiControllers(assembly);

            builder.RegisterType<RunkeeperIntegration>().As<IRunkeeperIntegration>();

            builder.RegisterType<RunkeeperService>().As<IRunkeeperService>();
            builder.RegisterType<RunkeeperClient>().As<IRunkeeperClient>();

            builder.RegisterType<RunRepository>().As<IRunRepository>();
            builder.RegisterType<SyncSettingsRepository>().As<ISyncSettingsRepository>();

            return builder;
        }
    }
}