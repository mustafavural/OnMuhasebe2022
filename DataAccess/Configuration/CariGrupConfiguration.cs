using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class CariGrupConfiguration : IEntityTypeConfiguration<CariGrup>
    {
        public void Configure(EntityTypeBuilder<CariGrup> builder)
        {
            builder.ToTable("CariGruplar");
            builder.HasKey(x => x.Id).HasName("PK_CariGruplar").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.CariId).HasColumnName(@"CariId").HasColumnType("int").IsRequired();
            builder.Property(x => x.CariCategoryId).HasColumnName(@"CariCategoryId").HasColumnType("int").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.CariCategory).WithMany(b => b.CariGruplar).HasForeignKey(c => c.CariCategoryId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CariCategory_1_M_CariGruplar");
            builder.HasOne(a => a.Cari).WithMany(b => b.CariGruplar).HasForeignKey(c => c.CariId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Cari_1_M_CariGruplar");
        }
    }
}