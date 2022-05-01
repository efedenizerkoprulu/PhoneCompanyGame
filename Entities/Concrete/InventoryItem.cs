using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class InventoryItem : ManageID, IEntity
    {
        public int ItemId { get; set; }
        public int InventoryId { get; set; }
        public Item Item { get; set; }
        public Inventory Inventory { get; set; }
    }
}
