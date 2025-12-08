using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pustok.Models;

namespace Pustok.Data.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasMany(b => b.BookImages).WithOne(bi => bi.Book).HasForeignKey(bi => bi.BookId);
        builder.Property(x=>x.Name)
            .HasMaxLength(100)
            .IsRequired();
    }
}