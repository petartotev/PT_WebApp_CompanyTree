using Autofac;
using CompanyTree.Common.Configuration;
using CompanyTree.Common.Configuration.Interfaces;
using CompanyTree.Domain.Services;
using CompanyTree.Domain.Services.Interfaces;
using CompanyTree.Repository;
using CompanyTree.Repository.Interfaces;

namespace CompanyTree.Autofac
{
    public static class DependencyInjection
    {
        public static ContainerBuilder ConfigureHost(this ContainerBuilder builder)
        {
            builder.RegisterType<DbContext>().As<IDbContext>().SingleInstance();
            builder.RegisterType<EnvironmentSettings>().As<IDbSettings>().SingleInstance();

            builder.RegisterType<EmployeesService>().As<IEmployeesService>().SingleInstance();
            builder.RegisterType<RolesService>().As<IRolesService>().SingleInstance();
            builder.RegisterType<TeamsService>().As<ITeamsService>().SingleInstance();

            builder.RegisterType<EmployeesRepository>().As<IEmployeesRepository>().SingleInstance();
            builder.RegisterType<RolesRepository>().As<IRolesRepository>().SingleInstance();
            builder.RegisterType<TeamsRepository>().As<ITeamsRepository>().SingleInstance();

            return builder;
        }
    }
}
