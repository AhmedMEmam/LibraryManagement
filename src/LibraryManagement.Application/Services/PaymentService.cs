using AutoMapper;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces.Persistence;
using LibraryManagement.Application.Interfaces.Services;
using LibraryManagement.Application.Services.Base;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Services;

public class PaymentService : CrudService<Payment, PaymentDto, PaymentCreateDto>, IPaymentService
{
    public PaymentService(IGenericRepository<Payment> repository, IUnitOfWork unitOfWork, IMapper mapper)
        : base(repository, unitOfWork, mapper)
    {
    }
}
