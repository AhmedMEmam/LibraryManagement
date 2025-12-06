using AutoMapper;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces.Persistence;
using LibraryManagement.Application.Interfaces.Services;
using LibraryManagement.Application.Services.Base;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Services;

public class BorrowingRecordService : CrudService<BorrowingRecord, BorrowingRecordDto, BorrowingRecordCreateDto>, IBorrowingRecordService
{
    public BorrowingRecordService(IGenericRepository<BorrowingRecord> repository, IUnitOfWork unitOfWork, IMapper mapper)
        : base(repository, unitOfWork, mapper)
    {
    }
}
