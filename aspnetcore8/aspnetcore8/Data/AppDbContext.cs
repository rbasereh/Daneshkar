using aspnetcore8.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore8.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> optionsBuilder)
            : base(optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().UseTpcMappingStrategy();
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Teacher>().ToTable("Teachers");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Person> Person { get; set; } 
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

    }
}
