using LibraryManagement.Application.Interfaces.Persistence;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Infrastructure.Data;

namespace LibraryManagement.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly LibraryDbContext _context;

    public UnitOfWork(LibraryDbContext context,
        IGenericRepository<Book> books,
        IGenericRepository<Category> categories,
        IGenericRepository<Author> authors,
        IGenericRepository<Publisher> publishers,
        IGenericRepository<Shelf> shelves,
        IGenericRepository<Member> members,
        IGenericRepository<Employee> employees,
        IGenericRepository<BorrowingRecord> borrowingRecords,
        IGenericRepository<Payment> payments)
    {
        _context = context;
        Books = books;
        Categories = categories;
        Authors = authors;
        Publishers = publishers;
        Shelves = shelves;
        Members = members;
        Employees = employees;
        BorrowingRecords = borrowingRecords;
        Payments = payments;
    }

    public IGenericRepository<Book> Books { get; }
    public IGenericRepository<Category> Categories { get; }
    public IGenericRepository<Author> Authors { get; }
    public IGenericRepository<Publisher> Publishers { get; }
    public IGenericRepository<Shelf> Shelves { get; }
    public IGenericRepository<Member> Members { get; }
    public IGenericRepository<Employee> Employees { get; }
    public IGenericRepository<BorrowingRecord> BorrowingRecords { get; }
    public IGenericRepository<Payment> Payments { get; }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public ValueTask DisposeAsync() => _context.DisposeAsync();
}
