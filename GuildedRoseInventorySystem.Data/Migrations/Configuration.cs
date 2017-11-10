namespace GuildedRoseInventorySystem.Data.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Context.EFContext";
        }

        protected override void Seed(Context.EFContext context)
        {
            context.ItemCategories.AddOrUpdate(
            p => p.Name,
            new ItemCategory { Name = "Weapon", Active = true },
            new ItemCategory { Name = "Food", Active = true },
            new ItemCategory { Name = "Backstage Passes", Active = true },
            new ItemCategory { Name = "Conjured", Active = true },
            new ItemCategory { Name = "Potion", Active = true },
            new ItemCategory { Name = "Misc", Active = true },
            new ItemCategory { Name = "Armor", Active = true }
            );

            context.SaveChanges();

            context.Items.AddOrUpdate(
            p => p.Name,
            new Item { Name = "Sword", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Weapon").Id, SellIn = 30, Quality = 50 },
            new Item { Name = "Axe", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Weapon").Id, SellIn = 40, Quality = 50 },
            new Item { Name = "Halberd", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Weapon").Id, SellIn = 60, Quality = 40 },
            new Item { Name = "Aged Brie", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Food").Id, SellIn = 50, Quality = 10 },
            new Item { Name = "Aged Milk", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Food").Id, SellIn = 20, Quality = 20 },
            new Item { Name = "Mutton", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Food").Id, SellIn = 10, Quality = 10 },
            new Item { Name = "Hand of Ragnaros", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Sulfuras").Id, SellIn = 80, Quality = 80 },
            new Item { Name = "I am Murloc", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Backstage Passes").Id, SellIn = 20, Quality = 10 },
            new Item { Name = "Raging Ogre", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Backstage Passes").Id, SellIn = 10, Quality = 10 },
            new Item { Name = "Giant Slayer", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Conjured").Id, SellIn = 15, Quality = 50 },
            new Item { Name = "Storm Hammer", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Conjured").Id, SellIn = 20, Quality = 50 },
            new Item { Name = "Belt of Giant Strength", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Conjured").Id, SellIn = 20, Quality = 40 },
            new Item { Name = "Cheese", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Food").Id, SellIn = 5, Quality = 5 },
            new Item { Name = "Potion of Healing", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Potion").Id, SellIn = 10, Quality = 50 },
            new Item { Name = "Bag of Holding", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Misc").Id, SellIn = 10, Quality = 50 },
            new Item { Name = "TAFKAL80ETC Concert", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Backstage Passes").Id, SellIn = 15, Quality = 20 },
            new Item { Name = "Elixir of the Mongoose", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Potion").Id, SellIn = 5, Quality = 7 },
            new Item { Name = "+ 5 Dexterity Vest", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Armor").Id, SellIn = 10, Quality = 20 },
            new Item { Name = "Full Plate Mail", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Armor").Id, SellIn = 50, Quality = 50 },
            new Item { Name = "Wooden Shield", ItemCategoryId = context.ItemCategories.FirstOrDefault(x => x.Name == "Armor").Id, SellIn = 10, Quality = 30 }
            );
        }
    }
}
