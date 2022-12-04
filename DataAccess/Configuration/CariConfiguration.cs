using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class CariConfiguration : IEntityTypeConfiguration<Cari>
    {
        public void Configure(EntityTypeBuilder<Cari> builder)
        {
            builder.ToTable("Cariler", "dbo");

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired();
            builder.Property(x => x.Kod).HasColumnName(@"Kod").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.Unvan).HasColumnName(@"Unvan").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.VergiDairesi).HasColumnName(@"VergiDairesi").HasColumnType("nvarchar(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.VergiNo).HasColumnName(@"VergiNo").HasColumnType("nvarchar(11)").IsRequired().HasMaxLength(11);

            builder.HasKey(x => x.Id).HasName("PK_Cariler").IsClustered();
            builder.HasIndex(x => x.Kod).HasDatabaseName("UK_Cariler_Kod").IsUnique();
            builder.HasIndex(x => x.Unvan).HasDatabaseName("UK_Cariler_Unvan").IsUnique();

            //Foreign Keys
            builder.HasOne(x => x.Adres).WithOne().HasForeignKey<Cari>(c => c.Id).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Adres_1_1o0_Cari"); ;
        }
    }
}