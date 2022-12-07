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
            builder.HasKey(x => x.Id).HasName("PK_MusteriEvraklar");

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedNever().UseIdentityColumn();
            builder.Property(x => x.AlinanCariId).HasColumnName(@"AlinanCariId").HasColumnType("int").IsRequired();
            builder.Property(x => x.AsilBorclu).HasColumnName(@"AsilBorclu").HasColumnType("nvarchar(250)").IsRequired().HasMaxLength(250);
            builder.Property(x => x.AlisTarihi).HasColumnName(@"AlisTarihi").HasColumnType("date").IsRequired();

            builder.HasIndex(x => x.Id).HasDatabaseName("UK_MusteriEvrak_Id").IsUnique();

            // Foreign keys
            builder.HasOne(x => x.DegerliEvrak).WithOne().HasForeignKey<MusteriEvrak>(c => c.Id).HasConstraintName("DegerliEvrak_1_1_MusteriEvrak");
            builder.HasOne(x => x.AlinanCariHareket).WithOne().HasForeignKey<MusteriEvrak>(x => x.Id).HasConstraintName("CariHareket_1_1o0_MusteriEvrak");
            builder.HasOne(x => x.AlinanCari).WithMany().HasForeignKey(x => x.AlinanCariId).HasConstraintName("Cari_1_M_MusteriEvraklar");
        }
    }
}