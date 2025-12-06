using AutoMapper;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces.Persistence;
using LibraryManagement.Application.Interfaces.Services;
using LibraryManagement.Application.Services.Base;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Services;

public class ShelfService : CrudService<Shelf, ShelfDto, ShelfCreateDto>, IShelfService
{
    public ShelfService(IGenericRepository<Shelf> repository, IUnitOfWork unitOfWork, IMapper mapper)
        : base(repository, unitOfWork, mapper)
    {
    }
}
