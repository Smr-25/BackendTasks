using FluentValidation;

namespace OnionArchApp.Application.Dtos.Color;

public record ColorCreateDto(string Name, string HexCode,int ProductId);

public class ColorCreateDtoValidator : AbstractValidator<ColorCreateDto>
{
    public ColorCreateDtoValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Color name is required.")
            .MaximumLength(50).WithMessage("Color name must not exceed 50 characters.");

        RuleFor(c => c.HexCode)
            .NotEmpty().WithMessage("Hex code is required.")
            .Matches("^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$").WithMessage("Hex code must be a valid format (e.g., #FFFFFF).");
        
        RuleFor(c => c.ProductId)
            .GreaterThan(0).WithMessage("ProductId must be a positive integer.");
    }
}