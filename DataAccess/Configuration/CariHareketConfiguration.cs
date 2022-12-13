using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class CariHareketConfiguration : IEntityTypeConfiguration<CariHareket>
    {
        public void Configure(EntityTypeBuilder<CariHareket> builder)
        {
            builder.ToTable("CariHareketler");
            builder.HasKey(x => x.Id).HasName("PK_CariHareketler").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.CariId).HasColumnName(@"CariId").HasColumnType("int").IsRequired();
            builder.Property(x => x.Tutar).HasColumnName(@"Tutar").HasColumnType("money").IsRequired();
            builder.Property(x => x.Tarih).HasColumnName(@"Tarih").HasColumnType("date").IsRequired();
            builder.Property(x => x.Aciklama).HasColumnName(@"Aciklama").HasColumnType("nvarchar(500)").IsRequired(false).HasMaxLength(500);

            // Foreign keys
            builder.HasOne(a => a.Cari).WithMany(b => b.CariHareketler).HasForeignKey(c => c.CariId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Cari_1_M_CariHareketler");
        }
    }
}