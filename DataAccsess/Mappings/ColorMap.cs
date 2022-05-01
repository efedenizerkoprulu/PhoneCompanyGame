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
    public class ColorMap : IEntityTypeConfiguration<Color>
    {
        //Color table Confing
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ColorName).HasMaxLength(25).HasColumnType("Varchar").IsRequired();

            builder.ToTable("Colors");

            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.ColorName).HasColumnName("ColorName");
        }
    }
}
