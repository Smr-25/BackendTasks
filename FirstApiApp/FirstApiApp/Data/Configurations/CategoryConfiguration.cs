using FirstApiApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstApiApp.Data.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Description).HasMaxLength(500);
        builder.Property(c => c.CreatedDate).HasDefaultValue(DateTime.UtcNow.ToString("yyyy-MM-dd"));
        builder.Property(c => c.UptadeDate).IsRequired(false);
        
        builder.HasData(
            new Category
            {
                Id = 1,
                Name = "Sample Category 1",
                Description = "This is a sample category 1"
            },
            new Category
            {
                Id = 2,
                Name = "Sample Category 2",
                Description = "This is a sample category 2"
            },
            new Category
            {
                Id = 3,
                Name = "Sample Category 3",
                Description = "This is a sample category 3"
            },
            new Category
            {
                Id = 4,
                Name = "Sample Category 4",
                Description = "This is a sample category 4"
            },
            new Category
            {
                Id = 5,
                Name = "Sample Category 5",
                Description = "This is a sample category 5"
            }
        );
    }
}