using aspnetcore9.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace aspnetcore9.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<LaptopProduct> LaptopProduct { get; set; }
        public DbSet<SmartPhoneProduct> SmartPhoneProduct { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");

            //modelBuilder.Entity<Product>().UseTptMappingStrategy();
            //modelBuilder.Entity<LaptopProduct>().ToTable("LaptopProduct");
            //modelBuilder.Entity<SmartPhoneProduct>().ToTable("SmartPhoneProduct");

            //modelBuilder.Entity<LaptopProduct>().UseTpcMappingStrategy().ToTable("LaptopProduct");
            //modelBuilder.Entity<SmartPhoneProduct>().UseTpcMappingStrategy().ToTable("SmartPhoneProduct");
            base.OnModelCreating(modelBuilder);
        }

    }
}
