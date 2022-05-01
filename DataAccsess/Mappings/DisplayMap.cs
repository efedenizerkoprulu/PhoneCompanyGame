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
    public class DisplayMap : IEntityTypeConfiguration<Display>
    {
        //Display table Confing
        public void Configure(EntityTypeBuilder<Display> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Brand).HasMaxLength(30).HasColumnType("Varchar").IsRequired();
            builder.Property(x => x.DisplayType).HasMaxLength(30).HasColumnType("Varchar").IsRequired();
            builder.Property(x => x.Inc).HasMaxLength(10).HasColumnType("Varchar").IsRequired();
           

            builder.ToTable("Displays");

            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.ItemId).HasColumnName("ItemId");
            builder.Property(x => x.Brand).HasColumnName("Brand");
            builder.Property(x => x.DisplayType).HasColumnName("DisplayType");
            builder.Property(x => x.Inc).HasColumnName("Inc");

            builder.HasOne(x => x.Item).WithMany(y => y.displays).HasForeignKey(z => z.ItemId);


        }
    }
}
