using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Emit;
using Task.Models.Domain;

namespace Task.Data
{
    public class DatabaseDBContext:DbContext
    {
        public DatabaseDBContext(DbContextOptions<DatabaseDBContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // This maps the model to the database table
            modelBuilder.Entity<Student>().ToTable("Student");

            string studentJson = System.IO.File.ReadAllText("Students.json");

            // Fix the typo in the namespace
            List<Student> students =
                System.Text.Json.JsonSerializer.Deserialize<List<Student>>(studentJson);

            // Use lowercase 'foreach'
            foreach (Student student in students)
            {
                modelBuilder.Entity<Student>().HasData(student);
            }

            modelBuilder.Entity<Student>().ToTable("Address");

            string addressJson = System.IO.File.ReadAllText("Addresses.json");

            // Fix the typo in the namespace
            List<Address> addresses =
                System.Text.Json.JsonSerializer.Deserialize<List<Address>>(addressJson);

            // Use lowercase 'foreach'
            foreach (Address address in addresses)
            {
                modelBuilder.Entity<Address>().HasData(address);
            }
        }
    }
}
