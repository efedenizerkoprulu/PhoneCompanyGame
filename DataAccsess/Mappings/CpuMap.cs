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
    public class CpuMap : IEntityTypeConfiguration<Cpu>
    {
        //Cpu table Confing
        public void Configure(EntityTypeBuilder<Cpu> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Brand).HasMaxLength(30).HasColumnType("Varchar").IsRequired();
           
            builder.ToTable("CPUs");

            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.ItemId).HasColumnName("ItemId");
            builder.Property(x => x.Brand).HasColumnName("Brand");

            builder.HasOne(x => x.Item).WithMany(y => y.cpus).HasForeignKey(z => z.ItemId);


        }
    }
}
