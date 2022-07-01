using Medical.Persistence;
using Medical.Persistence.EntityTypeContext;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Medical.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            _ = builder.Services.AddControllers();
            _ = builder.Services.AddEndpointsApiExplorer();
            _ = builder.Services.AddSwaggerGen();
            _ = builder.Services.AddPersistence(builder.Configuration);

            _ = builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                 .AddCookie(options => 
                 {
                     options.LoginPath = new PathString("/api/Test");
                 });

            WebApplication app = builder.Build();
            

            _ = Task.Run(() => Initializer.Initialize(
                app.Services.CreateScope()
                .ServiceProvider.GetRequiredService<DataBaseContext>()
                ));

            if (app.Environment.IsDevelopment())
            {
                _ = app.UseSwagger();
                _ = app.UseSwaggerUI();
            }

            _ = app.UseHttpsRedirection();
            _ = app.UseAuthorization();
            _ = app.MapControllers();

            app.Run();
        }
    }
}