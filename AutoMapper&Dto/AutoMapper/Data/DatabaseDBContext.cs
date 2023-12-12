using AutoMapper_Dto.Identity;
using AutoMapper_Dto.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;

namespace AutoMapper_Dto.Data
{
    public class DatabaseDBContext:DbContext
    {
        public DatabaseDBContext(DbContextOptions<DatabaseDBContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // for Employee Table

            // This maps the model to the database table
            modelBuilder.Entity<Employee>().ToTable("Employee");

            string employeeJson = System.IO.File.ReadAllText("Employee.json");

            // Fix the typo in the namespace
            List<Employee> employees =
                System.Text.Json.JsonSerializer.Deserialize<List<Employee>>(employeeJson);

            // Use lowercase 'foreach'
            foreach (Employee employee in employees)
            {
                modelBuilder.Entity<Employee>().HasData(employee);
            }

            // for Department Table

            modelBuilder.Entity<Department>().ToTable("Department");

            string departementJson = System.IO.File.ReadAllText("Department.json");

            // Fix the typo in the namespace
            List<Department> departements =
                System.Text.Json.JsonSerializer.Deserialize<List<Department>>(departementJson);

            // Use lowercase 'foreach'
            foreach (Department departement in departements)
            {
                modelBuilder.Entity<Department>().HasData(departement);
            }
        }
    }
}
