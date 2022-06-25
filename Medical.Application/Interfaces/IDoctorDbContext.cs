using Medical.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Medical.Application.Interfaces
{
    public interface IDoctorDbContext
    {
        DbSet<Doctor>? Doctors { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
    }
}
