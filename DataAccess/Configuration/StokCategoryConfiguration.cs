using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class StokCategoryConfiguration : IEntityTypeConfiguration<StokCategory>
    {
        public void Configure(EntityTypeBuilder<StokCategory> builder)
        {
            builder.ToTable("StokCategoryler", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_StokCategory").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Ad).HasColumnName(@"Ad").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);
        }
    }
}