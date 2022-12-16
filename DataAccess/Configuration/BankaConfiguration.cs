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
            builder.HasKey(x => x.Id).HasName("PK_Bankalar").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired();
            builder.Property(x => x.BankaAd).HasColumnName(@"BankaAd").HasColumnType("nvarchar(100)").IsRequired().HasMaxLength(100);
            builder.Property(x => x.BankaSubeAd).HasColumnName(@"BankaSubeAd").HasColumnType("nvarchar(100)").IsRequired().HasMaxLength(100);
            builder.Property(x => x.HesapNo).HasColumnName(@"HesapNo").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(50);

            builder.HasIndex(x => x.HesapNo).HasDatabaseName("UK_Banka_No").IsUnique();

            //Foreign Keys
            builder.HasOne(x => x.Adres).WithOne().HasForeignKey<Banka>(c => c.Id).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Banka_1_1_Adres");
        }
    }


}