using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Color : ManageID, IEntity
    {
        public Color()
        {
            myProducts = new List<MyProduct>();
        }
        public string ColorName { get; set; }
        public List<MyProduct> myProducts { get; set; }

    }
}
