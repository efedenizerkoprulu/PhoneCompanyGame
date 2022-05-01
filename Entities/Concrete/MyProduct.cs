using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MyProduct : ManageID, IEntity
    {
        // field 
        public int GameDataId { get; set; }
        public int ProductColorId { get; set; }
        public string ProductName { get; set; }
        public decimal AveragePoint { get; set; }
        public decimal ProductSalesGain { get; set; }
        public bool BestProduct { get; set; }



        //Relationships
        public GameData gameData { get; set; }
        public Color color { get; set; }
      

    }
}
