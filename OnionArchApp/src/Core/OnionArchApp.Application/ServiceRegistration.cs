using Microsoft.Extensions.DependencyInjection;
using OnionArchApp.Application.Services.Concretes;
using OnionArchApp.Application.Services.Interfaces;

namespace OnionArchApp.Application;

public static class ServiceRegistration
{
    extension(IServiceCollection services){
        public void AddApplicationServices()
        {
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}