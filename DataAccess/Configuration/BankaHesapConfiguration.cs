using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class BankaHesapConfiguration : IEntityTypeConfiguration<BankaHesap>
    {
        public void Configure(EntityTypeBuilder<BankaHesap> builder)
        {
            builder.ToTable("BankaHesaplar", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_Bankalar").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired();
            builder.Property(x => x.BankaAd).HasColumnName(@"BankaAd").HasColumnType("nvarchar(100)").IsRequired().HasMaxLength(100);
            builder.Property(x => x.BankaSubeAd).HasColumnName(@"BankaSubeAd").HasColumnType("nvarchar(100)").IsRequired().HasMaxLength(100);
            builder.Property(x => x.HesapNo).HasColumnName(@"HesapNo").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(50);

            builder.HasIndex(x => x.HesapNo).HasDatabaseName("UK_BankaHesap_No").IsUnique();

            //Foreign Keys
            builder.HasOne(x => x.Adres).WithOne().HasForeignKey<BankaHesap>(c => c.Id).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("BankaHesap_1_1_Adres");
        }
    }


}