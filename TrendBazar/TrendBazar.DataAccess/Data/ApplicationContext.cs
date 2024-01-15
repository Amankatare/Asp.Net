using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrendBazar.Entities.Entities;
using TrendBazar.Entities.Identity;

namespace TrendBazar.DataAccess.Data
{
    public class ApplicationContext :IdentityDbContext
    {
        // ---------------------------------------- Constructor --------------------------------------------

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }



        // -------------------------------------------- Entities ----------------------------------------------
        
        
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Order> Order { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }


        // -------------------------------------------- Identity ----------------------------------------------

        
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<ApplicationRole> ApplicationRoles { get; set; }

    }
}
