using Medical.Application.Interfaces;
using Medical.Persistence.EntityTypeContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MySql");            
            services.AddDbContext<DoctorDbContext>(options =>
            {
                options.UseMySQL(connectionString);
            });
            services.AddScoped<IDoctorDbContext>(provider =>
                provider.GetService<DoctorDbContext>() ?? new DoctorDbContext(new DbContextOptions<DoctorDbContext>()));
            return services;
        }
    }
}
