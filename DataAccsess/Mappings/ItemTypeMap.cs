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
    public class ItemTypeMap:IEntityTypeConfiguration<ItemType>
    {
        //ItemType table Confing
        public void Configure(EntityTypeBuilder<ItemType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ItemName).HasMaxLength(30).HasColumnType("Varchar").IsRequired();

            builder.ToTable("ItemTypes");

            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x=> x.ItemName).HasColumnName("ItemName");
        }
    }
}
