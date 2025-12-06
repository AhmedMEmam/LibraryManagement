using LibraryManagement.Api.Controllers.Base;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces.Services;

namespace LibraryManagement.Api.Controllers;

public class EmployeesController : CrudController<EmployeeDto, EmployeeCreateDto>
{
    public EmployeesController(IEmployeeService service) : base(service)
    {
    }

    protected override int GetIdFromDto(EmployeeDto dto) => dto.Id;
}
