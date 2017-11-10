namespace GuildedRoseInventorySystem.Data.Context
{
    using Models;
    using System.Data.Entity;

  public class EFContext : DbContext
        {
            public EFContext()
                : base("name=DefaultConnection")
            {
                base.Configuration.ProxyCreationEnabled = false;
            }

            public DbSet<Item> Items { get; set; }
            public DbSet<ItemCategory> ItemCategories { get; set; }
        }
}
