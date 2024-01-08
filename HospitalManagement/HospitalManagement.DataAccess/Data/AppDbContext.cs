using HospitalManagement.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.DataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Patient> Patients { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Doctor>(entity => entity.HasOne(d => d.Id = d.PatientId));
            
        }
        */
    }
}
