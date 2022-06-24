using Medical.Application.Interfaces;
using Medical.Domain.Entity;
using Medical.Persistence.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Medical.Persistence.EntityTypeContext
{
    public class DoctorDbContext : DbContext, IDoctorDbContext
    {
        public DoctorDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Doctor>? Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
