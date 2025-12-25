using Microsoft.EntityFrameworkCore;
using PustokApp.Models;

namespace PustokApp.Data;

public class AppDbContext : DbContext
{
    public DbSet<Slider> Sliders { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}