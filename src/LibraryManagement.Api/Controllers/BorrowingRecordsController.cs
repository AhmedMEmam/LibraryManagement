using LibraryManagement.Api.Controllers.Base;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces.Services;

namespace LibraryManagement.Api.Controllers;

public class BorrowingRecordsController : CrudController<BorrowingRecordDto, BorrowingRecordCreateDto>
{
    public BorrowingRecordsController(IBorrowingRecordService service) : base(service)
    {
    }

    protected override int GetIdFromDto(BorrowingRecordDto dto) => dto.Id;
}
