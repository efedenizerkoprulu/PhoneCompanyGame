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
    public class ItemMap:IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.ItemName).HasMaxLength(50).HasColumnType("Varchar").IsRequired();
            builder.Property(x => x.UnitPrice).HasColumnType("Money");
            builder.Property(x => x.Unlocklevel);

            builder.ToTable("Items");

            builder.Property(x=> x.Id).HasColumnName("Id");
            builder.Property(x => x.ItemTypeId).HasColumnName("ItemTypeId");
            builder.Property(x => x.ItemName).HasColumnName("ItemName");
            builder.Property(x => x.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(x => x.Unlocklevel).HasColumnName("Unlocklevel");

            builder.HasOne(x => x.ItemType).WithMany(y => y.Items).HasForeignKey(z => z.ItemTypeId);

        }
    }
}
