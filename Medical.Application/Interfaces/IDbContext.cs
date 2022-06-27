using Medical.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Medical.Application.Interfaces
{
    public interface IDbContext 
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);        
    }
}
