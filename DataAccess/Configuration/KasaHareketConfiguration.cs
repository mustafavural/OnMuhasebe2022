using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class KasaHareketConfiguration : IEntityTypeConfiguration<KasaHareket>
    {
        public void Configure(EntityTypeBuilder<KasaHareket> builder)
        {
            builder.ToTable("KasaHareketler", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_KasaHareket");

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedNever().UseIdentityColumn();
            builder.Property(x => x.KasaId).HasColumnName(@"KasaId").HasColumnType("int").IsRequired();
            builder.Property(x => x.CariId).HasColumnName(@"CariId").HasColumnType("int").IsRequired();
            builder.Property(x => x.EvrakNo).HasColumnName(@"EvrakNo").HasColumnType("varchar(14)").IsRequired().IsUnicode(false).HasMaxLength(14);
            builder.Property(x => x.GirenCikanMiktar).HasColumnName(@"GirenCikanMiktar").HasColumnType("money").IsRequired();
            builder.Property(x => x.Tarih).HasColumnName(@"Tarih").HasColumnType("date").IsRequired();
            builder.Property(x => x.Aciklama).HasColumnName(@"Aciklama").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);

            builder.HasIndex(x => x.EvrakNo).HasDatabaseName("KasaHareket_EvrakNo").IsUnique();

            // Foreign keys
            builder.HasOne(a => a.Kasa).WithMany().HasForeignKey(c => c.KasaId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Kasa_1_M_KasaHareketler");
            builder.HasOne(x => x.Cari).WithMany().HasForeignKey(x => x.CariId).HasConstraintName("Cari_1_M_KasaHareketler");
            builder.HasOne(a => a.CariHareket).WithOne().HasForeignKey<KasaHareket>(c => c.Id).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CariHareket_1_1o0_KasaHareket");
        }
    }


}