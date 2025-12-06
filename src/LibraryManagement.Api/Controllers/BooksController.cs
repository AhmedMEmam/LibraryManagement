using LibraryManagement.Api.Controllers.Base;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces.Services;

namespace LibraryManagement.Api.Controllers;

public class BooksController : CrudController<BookDto, BookCreateDto>
{
    public BooksController(IBookService service) : base(service)
    {
    }

    protected override int GetIdFromDto(BookDto dto) => dto.Id;
}
