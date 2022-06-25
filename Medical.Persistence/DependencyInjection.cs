using Medical.Application.Interfaces;
using Medical.Persistence.EntityTypeContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Medical.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("MySql");
            _ = services.AddDbContext<DoctorDbContext>(options =>
            {
                _ = options.UseMySQL(connectionString);
            });

            
            var g  = services.AddScoped<IDoctorDbContext>(provider =>
            provider.GetService<DoctorDbContext>() ?? new DoctorDbContext(new DbContextOptions<DoctorDbContext>()));

            

            return services;
        }
    }
}
