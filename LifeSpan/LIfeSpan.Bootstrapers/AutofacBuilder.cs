using Autofac;
using LifeSpan.Repository;
using LifeSpan.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIfeSpan.Bootstrapers
{
    public static class AutofacBuilder
    {
        public static ContainerBuilder RegisterInterface(ContainerBuilder builder)
        {
            builder.RegisterType<LifeSpanService>().AsImplementedInterfaces().InstancePerLifetimeScope();


            builder.RegisterType<LifeSpanRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
            return builder;
        }
    }
}
