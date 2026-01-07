using Microsoft.EntityFrameworkCore;
using OnionArchApp.Domain.Entity;

namespace OnionArchApp.Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Category> Categories { get; set; }
    DbSet<Product> Products { get; set; }
    Task<int> SaveChangesAsync();
}