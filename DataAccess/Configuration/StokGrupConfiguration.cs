using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class StokGrupConfiguration : IEntityTypeConfiguration<StokGrup>
    {
        public void Configure(EntityTypeBuilder<StokGrup> builder)
        {
            builder.ToTable("StokGruplar");
            builder.HasKey(x => x.Id).HasName("PK_StokGrup").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.StokId).HasColumnName(@"StokId").HasColumnType("int").IsRequired();
            builder.Property(x => x.StokCategoryId).HasColumnName(@"StokCategoryId").HasColumnType("int").IsRequired();    
            
            // Foreign keys
            builder.HasOne(a => a.StokCategory).WithMany(b => b.StokGruplar).HasForeignKey(c => c.StokCategoryId).HasConstraintName("StokCategory_1_M_StokGruplar");
            builder.HasOne(a => a.Stok).WithMany(b => b.StokGruplar).HasForeignKey(c => c.StokId).HasConstraintName("Stok_1_M_StokGruplar");
        }
    }
}