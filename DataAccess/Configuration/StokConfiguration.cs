using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class StokConfiguration : IEntityTypeConfiguration<Stok>
    {
        public void Configure(EntityTypeBuilder<Stok> builder)
        {
            builder.ToTable("Stoklar", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_Stok").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Kod).HasColumnName(@"Kod").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Barkod).HasColumnName(@"Barkod").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Ad).HasColumnName(@"Ad").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x => x.Kdv).HasColumnName(@"KDV").HasColumnType("int").IsRequired();
            builder.Property(x => x.Birim).HasColumnName(@"Birim").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);

            builder.HasIndex(x => x.Ad).HasDatabaseName("UK_Stok_Ad").IsUnique();
            builder.HasIndex(x => x.Barkod).HasDatabaseName("UK_Stok_Barkod").IsUnique();
            builder.HasIndex(x => x.Kod).HasDatabaseName("UK_Stok_Kod").IsUnique();
        }
    }
}