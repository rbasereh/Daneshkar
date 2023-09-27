using aspnetcore7.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore7.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; } 
    }
}
