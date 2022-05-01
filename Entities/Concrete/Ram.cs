using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ram:ManageID,IEntity
    {
        public int ItemId { get; set; }
        public string Brand { get; set; }
        public string Capacity { get; set; }
       
        public Item Item { get; set; }

    }
}
