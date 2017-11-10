using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildedRoseInventorySystem.Business
{
    public abstract class InventoryItem
    {
        private int increment;

        public InventoryItem(int incrementValue = 1)
        {
            increment = incrementValue;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public virtual void EndOfDayUpdate()
        {
            if ((Quality - increment) <= 0)
                Quality = 0;
            else
                Quality = Quality - increment;
        }
    }
}
