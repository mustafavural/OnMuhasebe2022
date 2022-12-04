using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class CariCategoryConfiguration : IEntityTypeConfiguration<CariCategory>
    {
        public void Configure(EntityTypeBuilder<CariCategory> builder)
        {
            builder.ToTable("CariCategoryler", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_CariCategoryler").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Ad).HasColumnName(@"Ad").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);
        }
    }


}