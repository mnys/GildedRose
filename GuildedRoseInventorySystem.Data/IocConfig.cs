using Autofac;
using GuildedRoseInventorySystem.Data.Item;

namespace GuildedRoseInventorySystem.Data
{
    public class IocConfig
    {
        public static void RegisterComponents(ContainerBuilder builder)
        {
            builder.RegisterType<ItemRepository>().As<IItemRepository>();
        }

    }
}