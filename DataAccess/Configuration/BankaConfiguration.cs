using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class BankaConfiguration : IEntityTypeConfiguration<Banka>
    {
        public void Configure(EntityTypeBuilder<Banka> builder)
        {
            builder.ToTable("Bankalar");
            builder.HasKey(x => x.Id).HasName("PK_Banka").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.BankaAd).HasColumnName(@"BankaAd").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.BankaSubeAd).HasColumnName(@"BankaSubeAd").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.HesapNo).HasColumnName(@"HesapNo").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.IBAN).HasColumnName(@"IBAN").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);

            builder.HasIndex(x => x.HesapNo).HasDatabaseName("UK_Banka_HesapNo").IsUnique();
            builder.HasIndex(x => x.IBAN).HasDatabaseName("UK_Banka_IBAN").IsUnique();
        }
    }


}