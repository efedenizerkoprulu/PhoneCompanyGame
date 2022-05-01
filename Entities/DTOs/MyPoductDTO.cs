using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class MyPoductDTO
    {
        public int  Id { get; set; }
        public string ProductName { get; set; }
        public string ColorName { get; set; }
        public decimal AveragePoint { get; set; }
        public decimal ProductSalesGain { get; set; }
        public bool BestProduct { get; set; }
    }
}
