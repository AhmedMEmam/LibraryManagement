using AutoMapper;
using LibraryManagement.Application.DTOs;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Book, BookDto>().ReverseMap();
        CreateMap<BookCreateDto, Book>();

        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<CategoryCreateDto, Category>();

        CreateMap<Author, AuthorDto>().ReverseMap();
        CreateMap<AuthorCreateDto, Author>();

        CreateMap<Publisher, PublisherDto>().ReverseMap();
        CreateMap<PublisherCreateDto, Publisher>();

        CreateMap<Shelf, ShelfDto>().ReverseMap();
        CreateMap<ShelfCreateDto, Shelf>();

        CreateMap<Member, MemberDto>().ReverseMap();
        CreateMap<MemberCreateDto, Member>();

        CreateMap<Employee, EmployeeDto>().ReverseMap();
        CreateMap<EmployeeCreateDto, Employee>();

        CreateMap<BorrowingRecord, BorrowingRecordDto>().ReverseMap();
        CreateMap<BorrowingRecordCreateDto, BorrowingRecord>();

        CreateMap<Payment, PaymentDto>().ReverseMap();
        CreateMap<PaymentCreateDto, Payment>();
    }
}
