using System.Data.Entity;

namespace Practice_01.Models
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}