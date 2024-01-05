using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccess.Data
{
    public class LearnContext:DbContext
    {
        public LearnContext(DbContextOptions<LearnContext> options) : base(options)
        {
             
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Designation> Designations { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<RefreshToken> RefreshTokens { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
