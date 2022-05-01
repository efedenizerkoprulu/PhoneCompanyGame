using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccsess.Mappings
{
    public class MyProductMap:IEntityTypeConfiguration<MyProduct>
    {
        //Myproduct table Confing
        public void Configure(EntityTypeBuilder<MyProduct> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ProductName).HasMaxLength(30).HasColumnType("Varchar").IsRequired();
            builder.Property(x => x.AveragePoint);
            builder.Property(x => x.ProductSalesGain);
            builder.Property(x => x.BestProduct).HasDefaultValueSql("0");

            builder.ToTable("MyProducts");

            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.GameDataId).HasColumnName("GameDataId");
            builder.Property(x => x.ProductColorId).HasColumnName("ProductColorId");
            builder.Property(x => x.ProductName).HasColumnName("ProductName");
            builder.Property(x => x.AveragePoint).HasColumnName("AveragePoint");
            builder.Property(x => x.ProductSalesGain).HasColumnName("ProductSalesGain");
            builder.Property(x => x.BestProduct).HasColumnName("BestProduct");

            // Relationships

            builder.HasOne(x=> x.gameData).WithMany(y=> y.myProducts).HasForeignKey(z=>z.GameDataId);

            builder.HasOne(x => x.color).WithMany(y => y.myProducts).HasForeignKey(z => z.ProductColorId);

           

        }
    }
}
