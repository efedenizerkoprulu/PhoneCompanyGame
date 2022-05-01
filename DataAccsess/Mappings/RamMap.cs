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
    public class RamMap: IEntityTypeConfiguration<Ram>
    {
        //Ram table Confing
        public void Configure(EntityTypeBuilder<Ram> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Brand).HasMaxLength(30).HasColumnType("Varchar").IsRequired();
            builder.Property(x => x.Capacity).HasMaxLength(5).HasColumnType("Varchar").IsRequired();
           

            builder.ToTable("Rams");

            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.ItemId).HasColumnName("ItemId");
            builder.Property(x => x.Brand).HasColumnName("Brand");
            builder.Property(x => x.Capacity).HasColumnName("Capacity");

            builder.HasOne(x => x.Item).WithMany(y => y.rams).HasForeignKey(z => z.ItemId);
        }
    }
}
