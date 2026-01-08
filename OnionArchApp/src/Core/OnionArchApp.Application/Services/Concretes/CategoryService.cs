using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using OnionArchApp.Application.Dtos.Category;
using OnionArchApp.Application.Interfaces;
using OnionArchApp.Application.Models;
using OnionArchApp.Application.Services.Interfaces;
using OnionArchApp.Domain.Entities;

namespace OnionArchApp.Application.Services.Concretes;

public class CategoryService(IApplicationDbContext applicationDbContext, IMapper mapper, IValidator<CategoryCreateDto> validator) : ICategoryService
{
    public async Task<ResponseModel<List<CategoryReturnDto>>> GetAllCategoriesAsync()
    {
        var categories = await applicationDbContext.Categories.ToListAsync();
        var categoryReturnDtos = mapper.Map<List<CategoryReturnDto>>(categories);
        return ResponseModel<List<CategoryReturnDto>>.Success(categoryReturnDtos);
    }

    public async Task<ResponseModel<CategoryReturnDto>> CreateCategoryAsync(CategoryCreateDto categoryDto)
    {
        if(await applicationDbContext.Categories.AnyAsync(c => c.Name == categoryDto.Name))
            throw new ValidationException("A category with the same name already exists.");
        var validationResult = await validator.ValidateAsync(categoryDto);
        if(!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);
        var category = mapper.Map<Category>(categoryDto);
        await applicationDbContext.Categories.AddAsync(category);
        await applicationDbContext.SaveChangesAsync();
        
        var categoryReturnDto = mapper.Map<CategoryReturnDto>(category);
        return ResponseModel<CategoryReturnDto>.Success(categoryReturnDto);
    }

    public async Task UpdateCategoryAsync(int categoryId, CategoryUpdateDto categoryDto)
    {
            throw new NotImplementedException();
    }

    public async Task DeleteCategoryAsync(int categoryId)
    {
        throw new NotImplementedException();
    }
}