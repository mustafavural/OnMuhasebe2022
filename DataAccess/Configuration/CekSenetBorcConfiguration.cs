﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class CekSenetBorcConfiguration : IEntityTypeConfiguration<CekSenetBorc>
    {
        public void Configure(EntityTypeBuilder<CekSenetBorc> builder)
        {
            builder.ToTable("CekSenetBorclar");
            builder.HasKey(x => x.Id).HasName("PK_CekSenetBorc");

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.No).HasColumnName(@"No").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.BordroTediyeId).HasColumnName(@"BordroTediyeId").HasColumnType("int").IsRequired();
            builder.Property(x => x.Vade).HasColumnName(@"Vade").HasColumnType("date").IsRequired();
            builder.Property(x => x.Tutar).HasColumnName(@"Tutar").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Aciklama).HasColumnName(@"Aciklama").HasColumnType("nvarchar(250)").IsRequired(false).HasMaxLength(250);

            builder.HasIndex(x => x.No).HasDatabaseName("UK_CekSenetBordrolar_No").IsUnique();

            // Foreign keys
            builder.HasOne(a => a.BordroTediye).WithMany(b=>b.CekSenetBorclar).HasForeignKey(x => x.BordroTediyeId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CekSenetBordro_1_M_TediyeCekSenetBorc");
        }
    }
}