using Microsoft.EntityFrameworkCore;
using OnionArchApp.Domain.Entities;

namespace OnionArchApp.Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Category> Categories { get; set; }
    DbSet<Product> Products { get; set; }
    Task<int> SaveChangesAsync();
}