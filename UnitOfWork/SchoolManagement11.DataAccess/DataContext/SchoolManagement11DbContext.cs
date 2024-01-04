using Microsoft.EntityFrameworkCore;
using SchoolManagement11.Domains.Entities;

namespace SchoolManagement11.DataAccess.DataContext
{
    public class SchoolManagement11DbContext : DbContext
    {
        public SchoolManagement11DbContext(DbContextOptions<SchoolManagement11DbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentActivity> StudentActivities { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
