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
    public class InventoryItemMap : IEntityTypeConfiguration<InventoryItem>
    {
        public void Configure(EntityTypeBuilder<InventoryItem> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("InventoryItems");

            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.InventoryId).HasColumnName("InventoryId");;
            builder.Property(x => x.ItemId).HasColumnName("ItemId");

            builder.HasOne(x => x.Item).WithMany(y => y.inventoryItems).HasForeignKey(z => z.ItemId);
            
            builder.HasOne(x => x.Inventory).WithMany(y => y.inventoryItems).HasForeignKey(z => z.InventoryId);

        }
    }
}
