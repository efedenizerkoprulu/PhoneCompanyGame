using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Inventory:ManageID,IEntity
    {
        public int AccountId { get; set; }

        //Relationships
        public Account account { get; set; }
        public List<InventoryItem> inventoryItems { get; set; }


    }
}
