using AutoMapper;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces.Persistence;
using LibraryManagement.Application.Interfaces.Services;
using LibraryManagement.Application.Services.Base;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Services;

public class BookService : CrudService<Book, BookDto, BookCreateDto>, IBookService
{
    public BookService(IGenericRepository<Book> repository, IUnitOfWork unitOfWork, IMapper mapper)
        : base(repository, unitOfWork, mapper)
    {
    }
}
