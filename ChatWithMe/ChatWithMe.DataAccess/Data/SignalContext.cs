using ChatWithMe.Entities.Entities;
using ChatWithMe.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChatWithMe.DataAccess.Data
{
    public class SignalContext : IdentityDbContext
    {
        public SignalContext(DbContextOptions<SignalContext> options): base(options) { }

        public DbSet<AppUser> appUsers { get; set; }

        public DbSet<AppRole> appRoles { get; set; }

        public DbSet<Message> Messages { get; set; }

    }
}
