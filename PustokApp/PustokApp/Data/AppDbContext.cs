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
    public DbSet<Setting> Settings { get; set; }
    

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        // Seed Data for Authors
        modelBuilder.Entity<Author>().HasData(
            new Author { Id = 1, Name = "F. Scott Fitzgerald" },
            new Author { Id = 2, Name = "Harper Lee" },
            new Author { Id = 3, Name = "George Orwell" },
            new Author { Id = 4, Name = "Jane Austen" },
            new Author { Id = 5, Name = "Mark Twain" },
            new Author { Id = 6, Name = "J.K. Rowling" },
            new Author { Id = 7, Name = "Ernest Hemingway" }
        );

        // Seed Data for Sliders
        modelBuilder.Entity<Slider>().HasData(
            new Slider 
            { 
                Id = 1, 
                Title = "Welcome to Pustok", 
                Description = "Your favorite online bookstore", 
                ImageUrl = "bg-images/home-2-slider-1.jpg", 
                ButtonText = "Shop Now", 
                ButtonUrl = "/books", 
                Order = 1
            },
            new Slider 
            { 
                Id = 2, 
                Title = "Best Sellers", 
                Description = "Discover amazing books", 
                ImageUrl = "bg-images/home-2-slider-2.jpg", 
                ButtonText = "Explore", 
                ButtonUrl = "/books", 
                Order = 2
            },
            new Slider 
            { 
                Id = 3, 
                Title = "New Arrivals", 
                Description = "Check out our latest collection", 
                ImageUrl = "bg-images/home-3-slider-1.jpg", 
                ButtonText = "View More", 
                ButtonUrl = "/books", 
                Order = 3
            }
        );

        // Seed Data for Tags
        modelBuilder.Entity<Tag>().HasData(
            new Tag { Id = 1, Name = "Fiction" },
            new Tag { Id = 2, Name = "Classic" },
            new Tag { Id = 3, Name = "Bestseller" },
            new Tag { Id = 4, Name = "Romance" },
            new Tag { Id = 5, Name = "Adventure" },
            new Tag { Id = 6, Name = "Science Fiction" },
            new Tag { Id = 7, Name = "Mystery" },
            new Tag { Id = 8, Name = "Historical" }
        );

        // Seed Data for Books
        modelBuilder.Entity<Book>().HasData(
            // F. Scott Fitzgerald - 3 books
            new Book 
            { 
                Id = 1, 
                Name = "The Great Gatsby", 
                Description = "A classic novel set in the Jazz Age", 
                Price = 15.99m, 
                Code = "BK001",
                DiscountPercent = 10,
                InStock = true,
                IsFeatured = true,
                IsNew = false,
                MainImageUrl = "products/product-1.jpg",
                HoverImageUrl = "products/product-2.jpg",
                AuthorId = 1
            },
            new Book 
            { 
                Id = 2, 
                Name = "Tender Is the Night", 
                Description = "A story of a psychiatrist's descent into alcoholism", 
                Price = 16.99m, 
                Code = "BK002",
                DiscountPercent = 5,
                InStock = true,
                IsFeatured = false,
                IsNew = false,
                MainImageUrl = "products/product-3.jpg",
                HoverImageUrl = "products/product-4.jpg",
                AuthorId = 1
            },
            new Book 
            { 
                Id = 3, 
                Name = "This Side of Paradise", 
                Description = "The debut novel about post-World War I youth", 
                Price = 14.99m, 
                Code = "BK003",
                DiscountPercent = 0,
                InStock = true,
                IsFeatured = false,
                IsNew = false,
                MainImageUrl = "products/product-5.jpg",
                HoverImageUrl = "products/product-6.jpg",
                AuthorId = 1
            },
            
            // Harper Lee - 2 books
            new Book 
            { 
                Id = 4, 
                Name = "To Kill a Mockingbird", 
                Description = "A gripping tale of racial injustice", 
                Price = 18.50m, 
                Code = "BK004",
                DiscountPercent = 15,
                InStock = true,
                IsFeatured = true,
                IsNew = false,
                MainImageUrl = "products/product-7.jpg",
                HoverImageUrl = "products/product-8.jpg",
                AuthorId = 2
            },
            new Book 
            { 
                Id = 5, 
                Name = "Go Set a Watchman", 
                Description = "A sequel to To Kill a Mockingbird", 
                Price = 17.99m, 
                Code = "BK005",
                DiscountPercent = 10,
                InStock = true,
                IsFeatured = false,
                IsNew = true,
                MainImageUrl = "products/product-9.jpg",
                HoverImageUrl = "products/product-10.jpg",
                AuthorId = 2
            },
            
            // George Orwell - 3 books
            new Book 
            { 
                Id = 6, 
                Name = "1984", 
                Description = "A dystopian social science fiction novel", 
                Price = 14.99m, 
                Code = "BK006",
                DiscountPercent = 0,
                InStock = true,
                IsFeatured = true,
                IsNew = true,
                MainImageUrl = "products/product-11.jpg",
                HoverImageUrl = "products/product-12.jpg",
                AuthorId = 3
            },
            new Book 
            { 
                Id = 7, 
                Name = "Animal Farm", 
                Description = "An allegorical novella about Soviet totalitarianism", 
                Price = 13.99m, 
                Code = "BK007",
                DiscountPercent = 5,
                InStock = true,
                IsFeatured = true,
                IsNew = false,
                MainImageUrl = "products/product-13.jpg",
                HoverImageUrl = "products/product-1.jpg",
                AuthorId = 3
            },
            new Book 
            { 
                Id = 8, 
                Name = "Homage to Catalonia", 
                Description = "Orwell's account of the Spanish Civil War", 
                Price = 15.50m, 
                Code = "BK008",
                DiscountPercent = 0,
                InStock = true,
                IsFeatured = false,
                IsNew = false,
                MainImageUrl = "products/product-2.jpg",
                HoverImageUrl = "products/product-3.jpg",
                AuthorId = 3
            },
            
            // Jane Austen - 3 books
            new Book 
            { 
                Id = 9, 
                Name = "Pride and Prejudice", 
                Description = "A romantic novel of manners", 
                Price = 12.99m, 
                Code = "BK009",
                DiscountPercent = 20,
                InStock = true,
                IsFeatured = true,
                IsNew = false,
                MainImageUrl = "products/product-4.jpg",
                HoverImageUrl = "products/product-5.jpg",
                AuthorId = 4
            },
            new Book 
            { 
                Id = 10, 
                Name = "Sense and Sensibility", 
                Description = "A story of two sisters and their romantic adventures", 
                Price = 13.99m, 
                Code = "BK010",
                DiscountPercent = 15,
                InStock = true,
                IsFeatured = false,
                IsNew = false,
                MainImageUrl = "products/product-6.jpg",
                HoverImageUrl = "products/product-7.jpg",
                AuthorId = 4
            },
            new Book 
            { 
                Id = 11, 
                Name = "Emma", 
                Description = "A comedy of manners about youthful hubris", 
                Price = 14.50m, 
                Code = "BK011",
                DiscountPercent = 10,
                InStock = true,
                IsFeatured = false,
                IsNew = false,
                MainImageUrl = "products/product-8.jpg",
                HoverImageUrl = "products/product-9.jpg",
                AuthorId = 4
            },
            
            // Mark Twain - 2 books
            new Book 
            { 
                Id = 12, 
                Name = "Adventures of Huckleberry Finn", 
                Description = "A classic American adventure novel", 
                Price = 13.50m, 
                Code = "BK012",
                DiscountPercent = 5,
                InStock = true,
                IsFeatured = true,
                IsNew = true,
                MainImageUrl = "products/product-10.jpg",
                HoverImageUrl = "products/product-11.jpg",
                AuthorId = 5
            },
            new Book 
            { 
                Id = 13, 
                Name = "The Adventures of Tom Sawyer", 
                Description = "A boy's adventures in a Mississippi River town", 
                Price = 12.99m, 
                Code = "BK013",
                DiscountPercent = 5,
                InStock = true,
                IsFeatured = false,
                IsNew = false,
                MainImageUrl = "products/product-12.jpg",
                HoverImageUrl = "products/product-13.jpg",
                AuthorId = 5
            },
            
            // J.K. Rowling - 3 books
            new Book 
            { 
                Id = 14, 
                Name = "Harry Potter and the Philosopher's Stone", 
                Description = "A young wizard's first year at Hogwarts", 
                Price = 19.99m, 
                Code = "BK014",
                DiscountPercent = 25,
                InStock = true,
                IsFeatured = true,
                IsNew = true,
                MainImageUrl = "products/product-1.jpg",
                HoverImageUrl = "products/product-2.jpg",
                AuthorId = 6
            },
            new Book 
            { 
                Id = 15, 
                Name = "Harry Potter and the Chamber of Secrets", 
                Description = "Harry's second year at Hogwarts", 
                Price = 20.99m, 
                Code = "BK015",
                DiscountPercent = 20,
                InStock = true,
                IsFeatured = true,
                IsNew = true,
                MainImageUrl = "products/product-3.jpg",
                HoverImageUrl = "products/product-4.jpg",
                AuthorId = 6
            },
            new Book 
            { 
                Id = 16, 
                Name = "Harry Potter and the Prisoner of Azkaban", 
                Description = "Harry's third year brings new dangers", 
                Price = 21.99m, 
                Code = "BK016",
                DiscountPercent = 20,
                InStock = true,
                IsFeatured = false,
                IsNew = true,
                MainImageUrl = "products/product-5.jpg",
                HoverImageUrl = "products/product-6.jpg",
                AuthorId = 6
            },
            
            // Ernest Hemingway - 2 books
            new Book 
            { 
                Id = 17, 
                Name = "The Old Man and the Sea", 
                Description = "An aging fisherman's epic struggle with a giant marlin", 
                Price = 16.50m, 
                Code = "BK017",
                DiscountPercent = 10,
                InStock = true,
                IsFeatured = true,
                IsNew = false,
                MainImageUrl = "products/product-7.jpg",
                HoverImageUrl = "products/product-8.jpg",
                AuthorId = 7
            },
            new Book 
            { 
                Id = 18, 
                Name = "A Farewell to Arms", 
                Description = "A love story set during World War I", 
                Price = 17.99m, 
                Code = "BK018",
                DiscountPercent = 5,
                InStock = true,
                IsFeatured = false,
                IsNew = false,
                MainImageUrl = "products/product-9.jpg",
                HoverImageUrl = "products/product-10.jpg",
                AuthorId = 7
            }
        );

        // Seed Data for BookTags (Many-to-Many relationship)
        modelBuilder.Entity<BookTag>().HasData(
            // The Great Gatsby
            new BookTag { BookId = 1, TagId = 1 }, // Fiction
            new BookTag { BookId = 1, TagId = 2 }, // Classic
            new BookTag { BookId = 1, TagId = 3 }, // Bestseller
            // Tender Is the Night
            new BookTag { BookId = 2, TagId = 1 }, // Fiction
            new BookTag { BookId = 2, TagId = 2 }, // Classic
            // This Side of Paradise
            new BookTag { BookId = 3, TagId = 1 }, // Fiction
            new BookTag { BookId = 3, TagId = 2 }, // Classic
            // To Kill a Mockingbird
            new BookTag { BookId = 4, TagId = 1 }, // Fiction
            new BookTag { BookId = 4, TagId = 2 }, // Classic
            new BookTag { BookId = 4, TagId = 8 }, // Historical
            new BookTag { BookId = 4, TagId = 3 }, // Bestseller
            // Go Set a Watchman
            new BookTag { BookId = 5, TagId = 1 }, // Fiction
            new BookTag { BookId = 5, TagId = 8 }, // Historical
            // 1984
            new BookTag { BookId = 6, TagId = 6 }, // Science Fiction
            new BookTag { BookId = 6, TagId = 2 }, // Classic
            new BookTag { BookId = 6, TagId = 3 }, // Bestseller
            // Animal Farm
            new BookTag { BookId = 7, TagId = 1 }, // Fiction
            new BookTag { BookId = 7, TagId = 2 }, // Classic
            new BookTag { BookId = 7, TagId = 3 }, // Bestseller
            // Homage to Catalonia
            new BookTag { BookId = 8, TagId = 8 }, // Historical
            new BookTag { BookId = 8, TagId = 2 }, // Classic
            // Pride and Prejudice
            new BookTag { BookId = 9, TagId = 4 }, // Romance
            new BookTag { BookId = 9, TagId = 2 }, // Classic
            new BookTag { BookId = 9, TagId = 3 }, // Bestseller
            // Sense and Sensibility
            new BookTag { BookId = 10, TagId = 4 }, // Romance
            new BookTag { BookId = 10, TagId = 2 }, // Classic
            // Emma
            new BookTag { BookId = 11, TagId = 4 }, // Romance
            new BookTag { BookId = 11, TagId = 2 }, // Classic
            // Adventures of Huckleberry Finn
            new BookTag { BookId = 12, TagId = 5 }, // Adventure
            new BookTag { BookId = 12, TagId = 1 }, // Fiction
            new BookTag { BookId = 12, TagId = 2 }, // Classic
            // The Adventures of Tom Sawyer
            new BookTag { BookId = 13, TagId = 5 }, // Adventure
            new BookTag { BookId = 13, TagId = 1 }, // Fiction
            new BookTag { BookId = 13, TagId = 2 }, // Classic
            // Harry Potter and the Philosopher's Stone
            new BookTag { BookId = 14, TagId = 1 }, // Fiction
            new BookTag { BookId = 14, TagId = 5 }, // Adventure
            new BookTag { BookId = 14, TagId = 3 }, // Bestseller
            // Harry Potter and the Chamber of Secrets
            new BookTag { BookId = 15, TagId = 1 }, // Fiction
            new BookTag { BookId = 15, TagId = 5 }, // Adventure
            new BookTag { BookId = 15, TagId = 3 }, // Bestseller
            // Harry Potter and the Prisoner of Azkaban
            new BookTag { BookId = 16, TagId = 1 }, // Fiction
            new BookTag { BookId = 16, TagId = 5 }, // Adventure
            new BookTag { BookId = 16, TagId = 7 }, // Mystery
            // The Old Man and the Sea
            new BookTag { BookId = 17, TagId = 1 }, // Fiction
            new BookTag { BookId = 17, TagId = 2 }, // Classic
            new BookTag { BookId = 17, TagId = 5 }, // Adventure
            // A Farewell to Arms
            new BookTag { BookId = 18, TagId = 1 }, // Fiction
            new BookTag { BookId = 18, TagId = 2 }, // Classic
            new BookTag { BookId = 18, TagId = 4 }  // Romance
        );

        // Seed Data for BookImages (Additional images for books)
        modelBuilder.Entity<BookImage>().HasData(
            new BookImage { Id = 1, ImageUrl = "products/product-details-1.jpg", BookId = 1 },
            new BookImage { Id = 2, ImageUrl = "products/product-details-2.jpg", BookId = 1 },
            new BookImage { Id = 3, ImageUrl = "products/product-details-3.jpg", BookId = 2 },
            new BookImage { Id = 4, ImageUrl = "products/product-details-4.jpg", BookId = 2 },
            new BookImage { Id = 5, ImageUrl = "products/product-details-5.jpg", BookId = 3 },
            new BookImage { Id = 6, ImageUrl = "products/product-details-1.jpg", BookId = 3 },
            new BookImage { Id = 7, ImageUrl = "products/product-details-2.jpg", BookId = 4 },
            new BookImage { Id = 8, ImageUrl = "products/product-details-3.jpg", BookId = 4 },
            new BookImage { Id = 9, ImageUrl = "products/product-details-4.jpg", BookId = 5 },
            new BookImage { Id = 10, ImageUrl = "products/product-details-5.jpg", BookId = 5 },
            new BookImage { Id = 11, ImageUrl = "products/product-details-1.jpg", BookId = 6 },
            new BookImage { Id = 12, ImageUrl = "products/product-details-2.jpg", BookId = 6 },
            new BookImage { Id = 13, ImageUrl = "products/product-details-3.jpg", BookId = 7 },
            new BookImage { Id = 14, ImageUrl = "products/product-details-4.jpg", BookId = 7 },
            new BookImage { Id = 15, ImageUrl = "products/product-details-5.jpg", BookId = 8 },
            new BookImage { Id = 16, ImageUrl = "products/product-details-1.jpg", BookId = 8 },
            new BookImage { Id = 17, ImageUrl = "products/product-details-2.jpg", BookId = 9 },
            new BookImage { Id = 18, ImageUrl = "products/product-details-3.jpg", BookId = 9 },
            new BookImage { Id = 19, ImageUrl = "products/product-details-4.jpg", BookId = 10 },
            new BookImage { Id = 20, ImageUrl = "products/product-details-5.jpg", BookId = 10 },
            new BookImage { Id = 21, ImageUrl = "products/product-details-1.jpg", BookId = 11 },
            new BookImage { Id = 22, ImageUrl = "products/product-details-2.jpg", BookId = 11 },
            new BookImage { Id = 23, ImageUrl = "products/product-details-3.jpg", BookId = 12 },
            new BookImage { Id = 24, ImageUrl = "products/product-details-4.jpg", BookId = 12 },
            new BookImage { Id = 25, ImageUrl = "products/product-details-5.jpg", BookId = 13 },
            new BookImage { Id = 26, ImageUrl = "products/product-details-1.jpg", BookId = 13 },
            new BookImage { Id = 27, ImageUrl = "products/product-details-2.jpg", BookId = 14 },
            new BookImage { Id = 28, ImageUrl = "products/product-details-3.jpg", BookId = 14 },
            new BookImage { Id = 29, ImageUrl = "products/product-details-4.jpg", BookId = 15 },
            new BookImage { Id = 30, ImageUrl = "products/product-details-5.jpg", BookId = 15 },
            new BookImage { Id = 31, ImageUrl = "products/product-details-1.jpg", BookId = 16 },
            new BookImage { Id = 32, ImageUrl = "products/product-details-2.jpg", BookId = 16 },
            new BookImage { Id = 33, ImageUrl = "products/product-details-3.jpg", BookId = 17 },
            new BookImage { Id = 34, ImageUrl = "products/product-details-4.jpg", BookId = 17 },
            new BookImage { Id = 35, ImageUrl = "products/product-details-5.jpg", BookId = 18 },
            new BookImage { Id = 36, ImageUrl = "products/product-details-1.jpg", BookId = 18 }
        );

        // Seed Data for Settings
        modelBuilder.Entity<Setting>().HasData(
            new Setting { Key = "SiteName", Value = "Pustok Bookstore" },
            new Setting { Key = "SiteEmail", Value = "info@pustok.com" },
            new Setting { Key = "SitePhone", Value = "+1 (555) 123-4567" },
            new Setting { Key = "SiteAddress", Value = "123 Book Street, Reading City, RC 12345" },
            new Setting { Key = "FacebookUrl", Value = "https://facebook.com/pustok" },
            new Setting { Key = "TwitterUrl", Value = "https://twitter.com/pustok" },
            new Setting { Key = "InstagramUrl", Value = "https://instagram.com/pustok" },
            new Setting { Key = "WorkingHours", Value = "Mon - Sat: 9:00 - 18:00" },
            new Setting { Key = "logourl", Value = "logo.png" },
            new Setting { Key = "phone", Value = "+1 (555) 123-4567" },
            new Setting { Key = "instagram", Value = "https://instagram.com/pustok" },
            new Setting { Key = "address", Value = "123 Book Street, Reading City, RC 12345" }
        );
    }

    
}