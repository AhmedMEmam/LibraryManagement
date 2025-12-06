using LibraryManagement.Api.Controllers.Base;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces.Services;

namespace LibraryManagement.Api.Controllers;

public class MembersController : CrudController<MemberDto, MemberCreateDto>
{
    public MembersController(IMemberService service) : base(service)
    {
    }

    protected override int GetIdFromDto(MemberDto dto) => dto.Id;
}
