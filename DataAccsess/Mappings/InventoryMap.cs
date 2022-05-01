using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Mappings
{
    public class InventoryMap:IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("Inventories");

            builder.Property(x => x.Id).HasColumnName("Id");
          builder.Property(x => x.AccountId).HasColumnName("AccountId");
           

            // Relationships

            builder.HasOne(x => x.account).WithMany(y => y.inventories).HasForeignKey(z => z.AccountId);


        }
    }
}
