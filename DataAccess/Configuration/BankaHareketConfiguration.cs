using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{

    public class BankaHareketConfiguration : IEntityTypeConfiguration<BankaHareket>
    {
        public void Configure(EntityTypeBuilder<BankaHareket> builder)
        {
            builder.ToTable("BankaHareketler");
            builder.HasKey(x => x.Id).HasName("PK_BankaHareketler");

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedNever().UseIdentityColumn();
            builder.Property(x => x.BankaId).HasColumnName(@"BankaId").HasColumnType("int").IsRequired();
            builder.Property(x => x.CariId).HasColumnName(@"CariId").HasColumnType("int").IsRequired();
            builder.Property(x => x.EvrakNo).HasColumnName(@"EvrakNo").HasColumnType("varchar(14)").IsRequired().IsUnicode(false).HasMaxLength(14);
            builder.Property(x => x.GirenCikanMiktar).HasColumnName(@"GirenCikanMiktar").HasColumnType("money").IsRequired();
            builder.Property(x => x.Tarih).HasColumnName(@"Tarih").HasColumnType("date").IsRequired();
            builder.Property(x => x.Aciklama).HasColumnName(@"Aciklama").HasColumnType("nvarchar(250)").IsRequired(false).HasMaxLength(250);

            builder.HasIndex(x => x.EvrakNo).HasDatabaseName("UK_BankaHareketler_EvrakNo").IsUnique();

            // Foreign keys
            builder.HasOne(a => a.Banka).WithMany().HasForeignKey(c => c.BankaId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Banka_1_M_BankaHareketler");
            builder.HasOne(x => x.Cari).WithMany().HasForeignKey(x => x.CariId).HasConstraintName("Cari_1_M_BankaHareketler");
            builder.HasOne(a => a.CariHareket).WithOne().HasForeignKey<BankaHareket>(c => c.Id).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CariHareket_1_1o0_BankaHareket");
        }
    }
}