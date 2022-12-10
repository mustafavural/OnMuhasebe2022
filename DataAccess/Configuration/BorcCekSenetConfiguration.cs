using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class BorcCekSenetConfiguration : IEntityTypeConfiguration<BorcCekSenet>
    {
        public void Configure(EntityTypeBuilder<BorcCekSenet> builder)
        {
            builder.ToTable("BorcCekSenetler");
            builder.HasKey(x => x.Id).HasName("PK_BorcCekSenetler");

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedNever().UseIdentityColumn();
            builder.Property(x => x.No).HasColumnName(@"No").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.BordroTediyeId).HasColumnName(@"BordroTediyeId").HasColumnType("int").IsRequired();
            builder.Property(x => x.Vade).HasColumnName(@"Vade").HasColumnType("date").IsRequired();
            builder.Property(x => x.Tutar).HasColumnName(@"Tutar").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Aciklama).HasColumnName(@"Aciklama").HasColumnType("nvarchar(250)").IsRequired(false).HasMaxLength(250);

            builder.HasIndex(x => x.No).HasDatabaseName("UK_KiymetliEvrakBordrolar_No").IsUnique();

            // Foreign keys
            builder.HasOne(a => a.BordroTediye).WithMany().HasForeignKey(x => x.BordroTediyeId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("KiymetliEvrakBordro_1_M_TediyeBorcCekSenet");
        }
    }
}