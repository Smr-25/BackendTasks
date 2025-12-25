using FirstApiApp.Data;
using Microsoft.EntityFrameworkCore;

namespace FirstApiApp;

public static class ServiceRegistration
{
    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddControllers();
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
    }
}