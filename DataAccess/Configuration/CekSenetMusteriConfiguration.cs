using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class CekSenetMusteriConfiguration : IEntityTypeConfiguration<CekSenetMusteri>
    {
        public void Configure(EntityTypeBuilder<CekSenetMusteri> builder)
        {
            builder.ToTable("CekSenetMusteriler");
            builder.HasKey(x => x.Id).HasName("PK_CekSenetMusteri");

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.No).HasColumnName(@"No").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.BordroTahsilatId).HasColumnName(@"BordroTahsilatId").HasColumnType("int").IsRequired();
            builder.Property(x => x.BordroTediyeId).HasColumnName(@"BordroTediyeId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.AsilBorclu).HasColumnName(@"AsilBorclu").HasColumnType("nvarchar(250)").IsRequired(false).HasMaxLength(250);
            builder.Property(x => x.Vade).HasColumnName(@"Vade").HasColumnType("date").IsRequired();
            builder.Property(x => x.Tutar).HasColumnName(@"Tutar").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Aciklama).HasColumnName(@"Aciklama").HasColumnType("nvarchar(250)").IsRequired(false).HasMaxLength(250);

            builder.HasIndex(x => x.No).HasDatabaseName("UK_CekSenetBordrolar_No").IsUnique();

            // Foreign keys
            builder.HasOne(x => x.BordroTahsilat).WithMany().HasForeignKey(x => x.BordroTahsilatId).HasConstraintName("CekSenetBordro_1_M_TahsilatCekSenetMusteri");
            builder.HasOne(a => a.BordroTediye).WithMany().HasForeignKey(x => x.BordroTediyeId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CekSenetBordro_1_M_TediyeCekSenetMusteri");
        }
    }
}