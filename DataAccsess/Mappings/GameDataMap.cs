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
    public class GameDataMap : IEntityTypeConfiguration<GameData>
    {
        //GameData table Confing
        public void Configure(EntityTypeBuilder<GameData> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CompanyName).HasMaxLength(50).HasColumnType("Varchar").IsRequired();
            builder.Property(x => x.BossName).HasMaxLength(30).HasColumnType("Varchar").IsRequired();
            builder.Property(x => x.GameDifficulty).HasMaxLength(10).HasColumnType("Varchar").IsRequired();
            builder.Property(x => x.Money).HasColumnType("Money").IsRequired();
            builder.Property(x => x.Xp).HasDefaultValueSql("0").IsRequired();
            builder.Property(x => x.XpLimit).HasDefaultValueSql("200").IsRequired();
            builder.Property(x => x.Level).HasDefaultValueSql("1").IsRequired();
            builder.Property(x => x.Day).HasDefaultValueSql("1").IsRequired();
            builder.Property(x => x.IsActiveSave).HasDefaultValueSql("1");

            builder.ToTable("GameDatas");

            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.CompanyName).HasColumnName("CompanyName");
            builder.Property(x => x.BossName).HasColumnName("BossName");
            builder.Property(x => x.GameDifficulty).HasColumnName("GameDifficulty");
            builder.Property(x => x.Money).HasColumnName("Money");
            builder.Property(x => x.Xp).HasColumnName("Xp");
            builder.Property(x => x.XpLimit).HasColumnName("XpLimit");
            builder.Property(x => x.Level).HasColumnName("Level");
            builder.Property(x => x.Day).HasColumnName("Day");
            builder.Property(x => x.IsActiveSave).HasColumnName("IsActiveSave");

            // Relationships

            builder.HasOne(x => x.Account).WithMany(y => y.gameDatas).HasForeignKey(z => z.AccountID);

        }
    }
}
