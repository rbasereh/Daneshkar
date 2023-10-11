using aspnetcore9.Models;
using Microsoft.EntityFrameworkCore;

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

            base.OnModelCreating(modelBuilder);
        }

    }
}
