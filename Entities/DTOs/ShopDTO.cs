using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ShopDTO: IEntityDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public byte UnlockLevel { get; set; }
        public string ItemTypeName { get; set; }
        public string BrandCpu { get; set; }
        public string BrandMotherBoard { get; set; }
        public string BrandDisplay { get; set; }
        public string BrandRam { get; set; }
        public string DisplayType { get; set; }
        public string Inc { get; set; }
        public string Capacity { get; set; }
        public string Chipset  { get; set; }
    }
}
