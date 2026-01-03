using AppSettingsMultiPlatformPackage;
using FirstApiApp.Data;
using FirstApiApp.Dtos.Categories;
using FirstApiApp.Models;
using FirstApiApp.Profiles;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FirstApiApp;

public static class ServiceRegistration
{
    public static void AddServices(this IServiceCollection services, IConfiguration configuration,WebApplicationBuilder builder)
    {
        services.AddAppSettingsMultiPlatformJson(builder,"Mac");
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddControllers();
        services.AddValidatorsFromAssemblyContaining<CategoryCreateDtoValidator>();
        services.AddFluentValidationAutoValidation();
        services.AddFluentValidationClientsideAdapters();
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        services.AddAutoMapper(opt=>
        {
            opt.AddProfile(new MapProfile(new HttpContextAccessor()));
        });
        services.AddHttpContextAccessor();
        // services.AddFluentValidationRulesToSwagger();   
        services.AddIdentity<AppUser,IdentityRole>(opt=>
        {
            opt.Password.RequireNonAlphanumeric = true;
            opt.Password.RequireUppercase = true;
            opt.Password.RequireLowercase = true;
            opt.Password.RequiredLength = 6;
        }).AddEntityFrameworkStores<AppDbContext>();
    }
    
}