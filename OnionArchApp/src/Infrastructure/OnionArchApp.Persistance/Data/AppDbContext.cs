using Microsoft.EntityFrameworkCore;
using OnionArchApp.Application.Interfaces;
using OnionArchApp.Domain.Entity;

namespace OnionArchApp.Persistance.Data;

public class AppDbContext : DbContext, IApplicationDbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public Task<int> SaveChangesAsync()
    {
        return base.SaveChangesAsync();
    }
}