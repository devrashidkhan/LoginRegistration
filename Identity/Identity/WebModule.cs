using Autofac;
using Identity.Models;

namespace Identity
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegisterModel>().AsSelf();
            builder.RegisterType<RegisterConfirmationModel>().AsSelf();
            builder.RegisterType<LoginModel>().AsSelf();

            base.Load(builder);
        }
    }
}
