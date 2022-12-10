using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class KiymetliEvrakBordroConfiguration : IEntityTypeConfiguration<KiymetliEvrakBordro>
    {
        public void Configure(EntityTypeBuilder<KiymetliEvrakBordro> builder)
        {
            builder.ToTable("KiymetliEvrakBordrolar");
            builder.HasKey(x => x.Id).HasName("PK_KiymetliEvrakBordrolar");

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedNever().UseIdentityColumn();
            builder.Property(x => x.No).HasColumnName(@"No").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Tur).HasColumnName(@"Tur").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.CariId).HasColumnName(@"CariId").HasColumnType("int").IsRequired();
            builder.Property(x => x.Tarih).HasColumnName(@"Tarih").HasColumnType("date").IsRequired();
            builder.Property(x => x.Aciklama).HasColumnName(@"Aciklama").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);

            builder.HasIndex(x => x.No).HasDatabaseName("UK_KiymetliEvrakBordrolar_No").IsUnique();

            // Foreign keys
            builder.HasOne(x => x.Cari).WithMany().HasForeignKey(x => x.CariId).HasConstraintName("Cari_1_M_KiymetliEvrakBordro");
            builder.HasOne(a => a.CariHareket).WithOne().HasForeignKey<KiymetliEvrakBordro>(c => c.Id).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CariHareket_1_1o0_KiymetliEvrakBordro");
        }
    }
}