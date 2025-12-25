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
    }
}