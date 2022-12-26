using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Core.DataAccess.Concrete.EntityFramework.Contexts
{
    public class MVMasterContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: $"server={Properties.Resources.String1};" +
                                                          $"Database={Properties.Resources.String2};" +
                                                          $"User Id={Properties.Resources.String3};" +
                                                          $"Password={Properties.Resources.String4}");
        }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCompany> UserCompanies { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}