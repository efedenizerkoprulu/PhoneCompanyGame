using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class InventoryDTO:IEntityDTO
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
