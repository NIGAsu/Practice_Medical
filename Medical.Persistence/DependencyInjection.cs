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
            _ = services.AddDbContext<DataBaseContext>(options =>
            {
                _ = options.UseMySQL(connectionString);
            });
            _ = services.AddScoped<IDbContext>(provider =>
            provider.GetService<DataBaseContext>() ?? new DataBaseContext(new DbContextOptions<DataBaseContext>()));

            return services;
        }
    }
}
