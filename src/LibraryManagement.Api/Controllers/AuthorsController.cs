using LibraryManagement.Api.Controllers.Base;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces.Services;

namespace LibraryManagement.Api.Controllers;

public class AuthorsController : CrudController<AuthorDto, AuthorCreateDto>
{
    public AuthorsController(IAuthorService service) : base(service)
    {
    }

    protected override int GetIdFromDto(AuthorDto dto) => dto.Id;
}
