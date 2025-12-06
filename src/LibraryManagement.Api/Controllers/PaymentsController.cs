using LibraryManagement.Api.Controllers.Base;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces.Services;

namespace LibraryManagement.Api.Controllers;

public class PaymentsController : CrudController<PaymentDto, PaymentCreateDto>
{
    public PaymentsController(IPaymentService service) : base(service)
    {
    }

    protected override int GetIdFromDto(PaymentDto dto) => dto.Id;
}
