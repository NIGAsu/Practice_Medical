using Medical.Application.Interfaces;
using Medical.Domain.Entity;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.ApplyConfiguration(new DoctorConfiguration());

            _ = modelBuilder.ApplyConfiguration(new AppointmentConfiguration());

            _ = modelBuilder.ApplyConfiguration(new PatientConfiguration());

            base.OnModelCreating(modelBuilder);

        }
    }
}
