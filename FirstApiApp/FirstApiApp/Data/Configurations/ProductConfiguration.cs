using FirstApiApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstApiApp.Data.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Description).HasMaxLength(500);
        builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
        builder.Property(p => p.CreatedDate).HasDefaultValue(DateTime.UtcNow.ToString("yyyy-MM-dd"));
        builder.Property(p => p.UptadeDate).IsRequired(false);

        builder.HasOne(p => p.Category)
               .WithMany(c => c.Products)
               .HasForeignKey(p => p.CategoryId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}