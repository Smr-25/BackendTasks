using Microsoft.EntityFrameworkCore;
using Pustok.Models;

namespace Pustok.Data;

public class AppDbContext : DbContext
{
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookImage> BookImages { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<BookTag> BookTags { get; set; }
    

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    
}