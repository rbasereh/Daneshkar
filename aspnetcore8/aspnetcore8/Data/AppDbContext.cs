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

            modelBuilder.Entity<PersonTpt>().UseTptMappingStrategy();
            modelBuilder.Entity<StudentTpt>().ToTable("StudentsTpt");
            modelBuilder.Entity<TeacherTpt>().ToTable("TeachersTpt");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Person> Person { get; set; } 
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

        public DbSet<PersonTpt> PersonTpt { get; set; }
        public DbSet<StudentTpt> StudentTpt { get; set; }
        public DbSet<TeacherTpt> TeacherTpt { get; set; }

    }
}
