using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccsess.Mappings
{
    public class MotherboardMap : IEntityTypeConfiguration<Motherboard>
    {
        //Motherboard table Confing
        public void Configure(EntityTypeBuilder<Motherboard> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Brand).HasMaxLength(30).HasColumnType("Varchar").IsRequired();
            builder.Property(x => x.Chipset).HasMaxLength(20).HasColumnType("Varchar").IsRequired();
           
            builder.ToTable("Motherboards");

            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.ItemId).HasColumnName("ItemId");
            builder.Property(x => x.Brand).HasColumnName("Brand");
            builder.Property(x => x.Chipset).HasColumnName("Chipset");

            builder.HasOne(x => x.Item).WithMany(y => y.motherboards).HasForeignKey(z => z.ItemId);
        }
    }
}
