using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class DegerliEvrakConfiguration : IEntityTypeConfiguration<DegerliEvrak>
    {
        public void Configure(EntityTypeBuilder<DegerliEvrak> builder)
        {
            builder.ToTable("DegerliEvraklar");
            builder.HasKey(x => x.Id).HasName("PK_DegerliEvrak").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedNever().UseIdentityColumn();
            builder.Property(x => x.Kod).HasColumnName(@"Kod").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.VerilenCariHareketId).HasColumnName(@"VerilenCariHareketId").HasColumnType("int").IsRequired();
            builder.Property(x => x.Vade).HasColumnName(@"Vade").HasColumnType("date").IsRequired();
            builder.Property(x => x.Tutar).HasColumnName(@"Tutar").HasColumnType("money").IsRequired();
            builder.Property(x => x.CikisTarihi).HasColumnName(@"CikisTarihi").HasColumnType("date").IsRequired();
            builder.Property(x => x.Aciklama).HasColumnName(@"Aciklama").HasColumnType("nvarchar(250)").IsRequired(false).HasMaxLength(250);

            builder.HasIndex(x => x.Kod).HasDatabaseName("UK_DegerliEvrak_Kod").IsUnique();

            // Foreign keys
            builder.HasOne(a => a.VerilenCariHareket).WithOne().HasForeignKey<DegerliEvrak>(c => c.VerilenCariHareketId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CariHareket_1_1o0_DegerliEvrak");
        }
    }
}