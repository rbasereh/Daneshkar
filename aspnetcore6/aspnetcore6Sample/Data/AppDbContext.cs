using aspnetcore6Sample.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore6Sample.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Person> Person { get; set; }
    }
}
