using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildedRoseInventorySystem.Data.Item
{
    public interface IItemRepository : IDisposable
    {
        Task<List<Models.Item>> Get();
        Task<Models.Item> GetItem(long itemId);
        Task<Models.Item> GetItem(string itemName);
        Task Saveitem(Models.Item item); 
    }
}
