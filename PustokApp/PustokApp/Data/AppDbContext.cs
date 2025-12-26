using Microsoft.EntityFrameworkCore;
using PustokApp.Models;

namespace PustokApp.Data;

public class AppDbContext : DbContext
{
    public DbSet<Slider> Sliders { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Slider>().HasData(
            new Slider
            {
                Id = 1,
                Title = "Discover Your Next Favorite Book",
                Description = "Explore our vast collection of books across all genres. Find your next great read today!",
                ImageUrl = "home-slider-1-ai.png",
                ButtonText = "Shop Now",
                ButtonUrl = "/books",
                Order = 1
            },
            new Slider
            {
                Id = 2,
                Title = "Exclusive Discounts on Bestsellers",
                Description = "Get up to 50% off on selected bestsellers. Limited time offer, don't miss out!",
                ImageUrl = "home-slider-2-ai.png",
                ButtonText = "Browse Deals",
                ButtonUrl = "/deals",
                Order = 2
            }
           
        );
    }
}