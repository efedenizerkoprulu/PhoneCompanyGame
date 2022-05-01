using DataAccsess.Mappings;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete.EntityFramework
{
    public class MyCompanyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= DESKTOP-1HP2GIP\SQLEXPRESS; Database=PhoneCompanyGame; Trusted_Connection=True");
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<Display> Displays { get; set; }
        public DbSet<GameData> GameDatas { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<MyProduct> MyProducts { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GameDataMap).Assembly);
        }
        
    }
}
