using LibraryManagement.Application.DTOs;

namespace LibraryManagement.Application.Interfaces.Services;

public interface IBookService : ICrudService<BookDto, BookCreateDto> { }
public interface ICategoryService : ICrudService<CategoryDto, CategoryCreateDto> { }
public interface IAuthorService : ICrudService<AuthorDto, AuthorCreateDto> { }
public interface IPublisherService : ICrudService<PublisherDto, PublisherCreateDto> { }
public interface IShelfService : ICrudService<ShelfDto, ShelfCreateDto> { }
public interface IMemberService : ICrudService<MemberDto, MemberCreateDto> { }
public interface IEmployeeService : ICrudService<EmployeeDto, EmployeeCreateDto> { }
public interface IBorrowingRecordService : ICrudService<BorrowingRecordDto, BorrowingRecordCreateDto> { }
public interface IPaymentService : ICrudService<PaymentDto, PaymentCreateDto> { }
