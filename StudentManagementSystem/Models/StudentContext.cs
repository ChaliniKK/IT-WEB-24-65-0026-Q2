using System.Data.Entity;

namespace StudentManagementSystem.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=StudentContext") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}