using Medical.Application.Interfaces;
using Medical.Domain.Entity;
using Medical.Domain.Hospitals;
using Medical.Domain.User;
using Medical.Persistence.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Medical.Persistence.EntityTypeContext
{
    public class DataBaseContext : DbContext, IDbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options) { }

        public DbSet<Doctor>? Doctors { get; set; }
        public DbSet<Appointment>? Appointments { get; set; }
        public DbSet<Patient>? Patients { get; set; }
        public DbSet<Hospital>? Hospitals { get; set; }
        public DbSet<User>? Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            _ = modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
            _ = modelBuilder.ApplyConfiguration(new PatientConfiguration());
            _ = modelBuilder.ApplyConfiguration(new HospitalsConfiguration());
            _ = modelBuilder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
