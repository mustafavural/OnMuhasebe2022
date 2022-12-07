using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class FaturaConfiguration : IEntityTypeConfiguration<Fatura>
    {
        public void Configure(EntityTypeBuilder<Fatura> builder)
        {
            builder.ToTable("Faturalar");
            builder.HasKey(x => x.Id).HasName("PK_Fatura");

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedNever().UseIdentityColumn();
            builder.Property(x => x.No).HasColumnName(@"No").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Tur).HasColumnName(@"Tur").HasColumnType("nvarchar(20)").IsRequired().HasMaxLength(20);
            builder.Property(x => x.CariId).HasColumnName(@"CariId").HasColumnType("int").IsRequired();
            builder.Property(x => x.Tarih).HasColumnName(@"Tarih").HasColumnType("date").IsRequired();
            builder.Property(x => x.KayitTarihi).HasColumnName(@"KayitTarihi").HasColumnType("date").IsRequired();
            builder.Property(x => x.Aciklama).HasColumnName(@"Aciklama").HasColumnType("nvarchar(500)").IsRequired(false).HasMaxLength(500);

            builder.HasIndex(x => x.No).HasDatabaseName("UK_Fatura_No").IsUnique();

            // Foreign keys
            builder.HasOne(x => x.Cari).WithMany().HasForeignKey(x => x.CariId).HasConstraintName("Cari_1_M_Faturalar");
            builder.HasOne(a => a.CariHareket).WithOne().HasForeignKey<Fatura>(c => c.Id).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CariHareket_1_1o0_Fatura");
        }
    }
}