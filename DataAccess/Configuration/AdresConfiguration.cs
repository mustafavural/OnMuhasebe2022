using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{


    public class AdresConfiguration : IEntityTypeConfiguration<Adres>
    {
        public void Configure(EntityTypeBuilder<Adres> builder)
        {
            builder.ToTable("Adresler");
            builder.HasKey(x => x.Id).HasName("PK_Adresler").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Telefon).HasColumnName(@"Telefon").HasColumnType("nvarchar(20)").IsRequired(false).HasMaxLength(20);
            builder.Property(x => x.Telefon2).HasColumnName(@"Telefon2").HasColumnType("nvarchar(20)").IsRequired(false).HasMaxLength(20);
            builder.Property(x => x.Fax).HasColumnName(@"Fax").HasColumnType("nvarchar(20)").IsRequired(false).HasMaxLength(20);
            builder.Property(x => x.Web).HasColumnName(@"Web").HasColumnType("varchar(150)").IsRequired(false).IsUnicode(false).HasMaxLength(150);
            builder.Property(x => x.Eposta).HasColumnName(@"Eposta").HasColumnType("varchar(150)").IsRequired(false).IsUnicode(false).HasMaxLength(150);
            builder.Property(x => x.IlceId).HasColumnName(@"IlceId").HasColumnType("int").IsRequired();
            builder.Property(x => x.AcikAdres).HasColumnName(@"AcikAdres").HasColumnType("nvarchar(500)").IsRequired(false).HasMaxLength(500);

            // Foreign keys
            builder.HasOne(a => a.Ilce).WithMany(b => b.Adresler).HasForeignKey(c => c.IlceId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Ilce_1_M_Adresler");
        }
    }
}