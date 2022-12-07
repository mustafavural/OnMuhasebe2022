using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class StokHareketConfiguration : IEntityTypeConfiguration<StokHareket>
    {
        public void Configure(EntityTypeBuilder<StokHareket> builder)
        {
            builder.ToTable("StokHareketler");
            builder.HasKey(x => x.Id).HasName("PK_StokHareket").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.StokId).HasColumnName(@"StokId").HasColumnType("int").IsRequired();
            builder.Property(x => x.FaturaId).HasColumnName(@"FaturaId").HasColumnType("int").IsRequired();
            builder.Property(x => x.Miktar).HasColumnName(@"Miktar").HasColumnType("decimal(18,6)").HasPrecision(18, 6).IsRequired();
            builder.Property(x => x.Birim).HasColumnName(@"Birim").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.Fiyat).HasColumnName(@"Fiyat").HasColumnType("money").IsRequired();
            builder.Property(x => x.BrutTutar).HasColumnName(@"BrutTutar").HasColumnType("money").IsRequired();
            builder.Property(x => x.Kdv).HasColumnName(@"KDV").HasColumnType("int").IsRequired();
            builder.Property(x => x.NetTutar).HasColumnName(@"NetTutar").HasColumnType("money").IsRequired();
            builder.Property(x => x.Tarih).HasColumnName(@"Tarih").HasColumnType("date").IsRequired();
            builder.Property(x => x.Aciklama).HasColumnName(@"Aciklama").HasColumnType("nvarchar(500)").IsRequired(false).HasMaxLength(500);

            // Foreign keys
            builder.HasOne(a => a.Stok).WithMany(b=>b.StokHareketler).HasForeignKey(c => c.StokId).HasConstraintName("Stok_1_M_StokHareketler");
            builder.HasOne(a => a.Fatura).WithMany(b => b.StokHareketler).HasForeignKey(c => c.FaturaId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Fatura_1_M_StokHareketler");
        }
    }
}