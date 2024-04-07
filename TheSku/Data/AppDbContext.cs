using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Configuration;
using System.Xml;

namespace TheSku.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConfigurationManager.ConnectionStrings["ConString"].ToString(), ServerVersion.AutoDetect(ConfigurationManager.ConnectionStrings["ConString"].ToString()));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(DefaultData.Users());
            modelBuilder.Entity<Country>().HasData(DefaultData.Countries());
            modelBuilder.Entity<Currency>().HasData(DefaultData.Currencies());
        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SupplierGroup> SupplierGroup { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerGroup> CustomerGroup { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Currency> Currency { get; set; }
    }
}
