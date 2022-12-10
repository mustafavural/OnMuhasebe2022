using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class MusteriEvrakConfiguration : IEntityTypeConfiguration<MusteriEvrak>
    {
        public void Configure(EntityTypeBuilder<MusteriEvrak> builder)
        {
            builder.ToTable("MusteriEvraklar");
            builder.HasKey(x => x.Id).HasName("PK_MusteriEvraklar").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Kod).HasColumnName(@"Kod").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.AlinanCariHareketId).HasColumnName(@"AlinanCariHareketId").HasColumnType("int").IsRequired();
            builder.Property(x => x.AlisTarihi).HasColumnName(@"AlisTarihi").HasColumnType("date").IsRequired();
            builder.Property(x => x.AsilBorclu).HasColumnName(@"AsilBorclu").HasColumnType("nvarchar(250)").IsRequired().HasMaxLength(250);
            builder.Property(x => x.Vade).HasColumnName(@"Vade").HasColumnType("date").IsRequired();
            builder.Property(x => x.Tutar).HasColumnName(@"Tutar").HasColumnType("money").IsRequired();
            builder.Property(x => x.VerilenCariHareketId).HasColumnName(@"VerilenCariHareketId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.CikisTarihi).HasColumnName(@"CikisTarihi").HasColumnType("date").IsRequired(false);
            builder.Property(x => x.Aciklama).HasColumnName(@"Aciklama").HasColumnType("nvarchar(250)").IsRequired(false).HasMaxLength(250);

            builder.HasIndex(x => x.Id).HasDatabaseName("UK_MusteriEvrak_Id").IsUnique();
            builder.HasIndex(x => x.Kod).HasDatabaseName("UK_MusteriEvrak_Kod").IsUnique();

            // Foreign keys
            builder.HasOne(x => x.AlinanCariHareket).WithOne().HasForeignKey<MusteriEvrak>(x => x.AlinanCariHareketId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CariHareket_1_1o0_AlinanMusteriHareket");
            builder.HasOne(x => x.VerilenCariHareket).WithOne().HasForeignKey<MusteriEvrak>(x => x.VerilenCariHareketId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CariHareket_1_1o0_VerilenMusteriHareket");
        }
    }
}