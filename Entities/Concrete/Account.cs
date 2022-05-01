using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Account : ManageID, IEntity
    {
        public Account()
        {
            gameDatas = new List<GameData>();
            inventories = new List<Inventory>();
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public DateTime AccountCreateDate { get; set; }
        public bool IsActiveAccount { get; set; }
        public List<GameData> gameDatas { get; set; }
        public List<Inventory> inventories { get; set; }
    }
}
