using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuildedRoseInventorySystem.Data.Models
{
    public class Item
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }

        public int ItemCategoryId {get; set; }
        public ItemCategory ItemCategory { get; set; }

        public int SellIn { get; set; }
        public int Quality { get; set; }
        public bool Active { get; set; }
    }
}
