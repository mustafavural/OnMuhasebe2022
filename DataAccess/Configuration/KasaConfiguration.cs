using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class KasaConfiguration : IEntityTypeConfiguration<Kasa>
    {
        public void Configure(EntityTypeBuilder<Kasa> builder)
        {
            builder.ToTable("Kasalar", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_Kasa").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Ad).HasColumnName(@"Ad").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);

            builder.HasIndex(x => x.Ad).HasDatabaseName("UK_Kasa_Ad").IsUnique();
        }
    }


}