using LibraryManagement.Api.Controllers.Base;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces.Services;

namespace LibraryManagement.Api.Controllers;

public class PublishersController : CrudController<PublisherDto, PublisherCreateDto>
{
    public PublishersController(IPublisherService service) : base(service)
    {
    }

    protected override int GetIdFromDto(PublisherDto dto) => dto.Id;
}
