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
            modelBuilder.Entity<User>().HasData(new User()
            {
                Name = "admin",
                Creation = DateTime.Now,
                Modified = DateTime.Now,
                ModifiedBy = "Administrator",
                Owner = "Administrator",
                UserName = "admin",
                Password = Security.EncryptString("admin")
            });
        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SupplierGroup> SupplierGroup { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerGroup> CustomerGroup { get; set; }
    }
}
