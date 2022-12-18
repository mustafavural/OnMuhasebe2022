using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class SIRKETLERContext : DbContext
    {
        public static string ServerName => "(localdb)\\MSSQLLocalDB";
        public static string DatabaseName => "SIRKET";
        public static string UserId => "sa";
        public static string Password => "sapass";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString: $"server={ServerName};Database={DatabaseName};User Id={UserId};Password={Password}");
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


        public DbSet<CekSenetBordro> CekSenetBordrolar { get; set; }
        public DbSet<CekSenetMusteri> CekSenetMusteriler { get; set; }
        public DbSet<CekSenetBorc> CekSenetBorclar { get; set; }


        public DbSet<Banka> Bankalar { get; set; }
        public DbSet<BankaHareket> BankaHareketler { get; set; }


        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
    }
}