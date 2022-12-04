﻿using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.Concrete.EntityFramework.Contexts
{
    public class MVMasterContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"server=(localdb)\MSSQLLocalDB;Database=MvOnMuhasebe2022;Trusted_Connection=True");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<UserCompany> UserCompanies { get; set; }
    }
}
