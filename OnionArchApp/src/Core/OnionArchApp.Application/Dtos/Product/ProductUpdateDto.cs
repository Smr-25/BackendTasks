using OnionArchApp.Domain.Enums;

namespace OnionArchApp.Application.Dtos.Product;

public record ProductUpdateDto(string Name, decimal Price, ProductStatus Status, int CategoryId);