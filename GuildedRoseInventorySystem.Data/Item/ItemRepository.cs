using GuildedRoseInventorySystem.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace GuildedRoseInventorySystem.Data.Item
{
    public class ItemRepository : IItemRepository
    {
        private EFContext efContext;

        public ItemRepository() {
            EFContext efContext = new EFContext();
        }

        public async Task<List<Models.Item>> Get()
        {
            return await efContext.Items.ToListAsync();
        }

        public async Task<Models.Item> GetItem (long itemId)
        {
            return await efContext.Items.FirstOrDefaultAsync(x => x.Id == itemId);
        }

        public async Task<Models.Item> GetItem(string itemName)
        {
            return await efContext.Items.FirstOrDefaultAsync(x => x.Name == itemName);
        }

        public async Task Saveitem(Models.Item item)
        {
            efContext.Items.Add(item);
            await efContext.SaveChangesAsync();
        }

        void IDisposable.Dispose()
        {
            efContext.Dispose();
        }
    }
}
