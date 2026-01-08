using OnionArchApp.Domain.Enums;

namespace OnionArchApp.Application.Dtos.Product;

public record ProductReturnDto(int Id, string Name, decimal Price, ProductStatus Status, string CategoryName);