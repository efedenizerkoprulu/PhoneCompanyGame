using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class GameData : ManageID, IEntity
    {
        public GameData()
        {
            myProducts = new List<MyProduct>();
        }
        public int AccountID { get; set; }
        public string CompanyName { get; set; }
        public string BossName { get; set; }
        public string GameDifficulty { get; set; }
        public decimal Money { get; set; }
        public int Xp { get; set; }
        public int XpLimit { get; set; }
        public byte Level { get; set; }
        public int Day { get; set; }
        public bool IsActiveSave { get; set; }


        public Account Account { get; set; }
       public int DataId { get; set; }
        public List<MyProduct> myProducts { get; set; }
    }
}
