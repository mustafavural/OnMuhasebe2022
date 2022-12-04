using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class SehirConfiguration : IEntityTypeConfiguration<Sehir>
    {
        public void Configure(EntityTypeBuilder<Sehir> builder)
        {
            builder.ToTable("Sehirler", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_Sehirler").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Ad).HasColumnName(@"Ad").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);

            builder.HasIndex(x => x.Ad).HasDatabaseName("UK_Sehir_Ad").IsUnique();
        }
    }
}