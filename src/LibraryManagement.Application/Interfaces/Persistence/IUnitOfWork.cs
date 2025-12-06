using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Interfaces.Persistence;

public interface IUnitOfWork : IAsyncDisposable
{
    IGenericRepository<Book> Books { get; }
    IGenericRepository<Category> Categories { get; }
    IGenericRepository<Author> Authors { get; }
    IGenericRepository<Publisher> Publishers { get; }
    IGenericRepository<Shelf> Shelves { get; }
    IGenericRepository<Member> Members { get; }
    IGenericRepository<Employee> Employees { get; }
    IGenericRepository<BorrowingRecord> BorrowingRecords { get; }
    IGenericRepository<Payment> Payments { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
