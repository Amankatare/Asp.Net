using Microsoft.EntityFrameworkCore;
using MVC2.Models;

namespace MVC2.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // This maps the model to the database table
            modelBuilder.Entity<Student>().ToTable("Student");

            string studentJson = System.IO.File.ReadAllText("Student.json");

            // Fix the typo in the namespace
            List<Student> students =
                System.Text.Json.JsonSerializer.Deserialize<List<Student>>(studentJson);

            // Use lowercase 'foreach'
            foreach (Student student in students)
            {
                modelBuilder.Entity<Student>().HasData(student);
            }
        }
    }
}
