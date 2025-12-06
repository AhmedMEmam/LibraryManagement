using LibraryManagement.Api.Controllers.Base;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces.Services;

namespace LibraryManagement.Api.Controllers;

public class CategoriesController : CrudController<CategoryDto, CategoryCreateDto>
{
    public CategoriesController(ICategoryService service) : base(service)
    {
    }

    protected override int GetIdFromDto(CategoryDto dto) => dto.Id;
}
