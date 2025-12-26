using FirstApiApp.Data;
using FirstApiApp.Profiles;
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
        services.AddAutoMapper(opt=>
        {
            opt.AddProfile<MapProfile>();
        });
        
    }
    
}