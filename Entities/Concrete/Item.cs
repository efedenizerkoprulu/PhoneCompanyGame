using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Item: ManageID,IEntity
    {
        
        public int ItemTypeId { get; set; }
        public string ItemName { get; set; }
        public int UnitPrice { get; set; }
        public byte Unlocklevel { get; set; }

        public List<Motherboard> motherboards { get; set; }
        public List<Cpu> cpus { get; set; }
        public List<Display> displays { get; set; }
        public List<Ram> rams { get; set; }
        public ItemType ItemType { get; set; }
        public List<InventoryItem> inventoryItems { get; set; }
    }
}
