using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ItemType : ManageID, IEntity
    {
        public ItemType()
        {
           Items = new List<Item>();
        }
        public string ItemName { get; set; }
        public List<Item> Items { get; set; }
    }
}
