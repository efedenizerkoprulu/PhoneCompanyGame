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
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        //Account table Confing
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(x => x.UserName).HasMaxLength(20).HasColumnType("Varchar").IsRequired();
            builder.Property(x => x.Password).HasMaxLength(20).HasColumnType("Varchar").IsRequired();
            builder.Property(x => x.Email).HasMaxLength(75).HasColumnType("Varchar").IsRequired();
            builder.Property(x => x.AccountCreateDate).HasDefaultValueSql("getdate()");
            builder.Property(x => x.IsActiveAccount).HasDefaultValueSql("0");

            builder.ToTable("Accounts");

            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.UserName).HasColumnName("UserName");
            builder.Property(x => x.Password).HasColumnName("Password");
            builder.Property(x => x.Email).HasColumnName("Email");
            builder.Property(x => x.AccountCreateDate).HasColumnName("AccountCreateDate");
            builder.Property(x => x.IsActiveAccount).HasColumnName("IsActiveAccount");


        }
    }
}
