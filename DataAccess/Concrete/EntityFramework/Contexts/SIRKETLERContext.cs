using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class SIRKETLERContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString: @"server=(localdb)\MSSQLLocalDB;Database=SIRKET;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<StokCategory> StokCategoryler { get; set; }
        public DbSet<StokGrup> StokGruplar { get; set; }
        public DbSet<StokHareket> StokHareketler { get; set; }


        public DbSet<Cari> Cariler { get; set; }
        public DbSet<CariCategory> CariCategoryler { get; set; }
        public DbSet<CariGrup> CariGruplar { get; set; }
        public DbSet<CariHareket> CariHareketler { get; set; }


        public DbSet<Fatura> Faturalar { get; set; }


        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<KasaHareket> KasaHareketler { get; set; }


        public DbSet<KiymetliEvrakBordro> KiymetliEvrakBordrolar { get; set; }
        public DbSet<MusteriCekSenet> MusteriCekSenetler { get; set; }
        public DbSet<BorcCekSenet> BorcCekSenetler { get; set; }


        public DbSet<BankaHesap> BankaHesaplar { get; set; }
        public DbSet<BankaHareket> BankaHareketler { get; set; }


        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
    }
}