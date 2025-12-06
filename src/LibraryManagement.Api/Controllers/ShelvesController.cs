using LibraryManagement.Api.Controllers.Base;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces.Services;

namespace LibraryManagement.Api.Controllers;

public class ShelvesController : CrudController<ShelfDto, ShelfCreateDto>
{
    public ShelvesController(IShelfService service) : base(service)
    {
    }

    protected override int GetIdFromDto(ShelfDto dto) => dto.Id;
}
