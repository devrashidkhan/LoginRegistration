using Autofac;
using Membership.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership
{
    public class MembershipModule : Module
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public MembershipModule(string connectionString, string assemblyName)
        {
            _connectionString = connectionString;
            _assemblyName = assemblyName;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().AsSelf()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("assemblyName", _assemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("assemblyName", _assemblyName)
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
