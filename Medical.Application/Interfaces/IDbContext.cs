using Medical.Domain.Entity;
using Medical.Domain.Hospitals;
using Medical.Domain.User;
using Microsoft.EntityFrameworkCore;

namespace Medical.Application.Interfaces
{
    public interface IDbContext
    {
        public DbSet<Doctor>? Doctors { get; set; }
        public DbSet<Appointment>? Appointments { get; set; }
        public DbSet<Patient>? Patients { get; set; }
        public DbSet<Hospital>? Hospitals { get; set; }
        public DbSet<User>? Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
    }
}
