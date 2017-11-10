using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildedRoseInventorySystem.Business
{
    public class IocConfig
    {
        public static void RegisterComponents(ContainerBuilder builder)
        {
            Data.IocConfig.RegisterComponents(builder);
        }

    }
}
