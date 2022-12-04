using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class IlceConfiguration : IEntityTypeConfiguration<Ilce>
    {
        public void Configure(EntityTypeBuilder<Ilce> builder)
        {
            builder.ToTable("Ilceler", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_Ilceler").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.SehirId).HasColumnName(@"SehirId").HasColumnType("int").IsRequired();
            builder.Property(x => x.Ad).HasColumnName(@"Ad").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);

            builder.HasIndex(x => x.Ad).HasDatabaseName("UK_Ilce_Ad").IsUnique();

            // Foreign keys
            builder.HasOne(a => a.Sehir).WithMany(s => s.Ilceler).HasForeignKey(c => c.SehirId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("Sehir_1_M_Ilceler");
        }
    }
}