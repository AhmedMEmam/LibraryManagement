using LibraryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure.Data;

public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books => Set<Book>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Publisher> Publishers => Set<Publisher>();
    public DbSet<Shelf> Shelves => Set<Shelf>();
    public DbSet<Member> Members => Set<Member>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<BorrowingRecord> BorrowingRecords => Set<BorrowingRecord>();
    public DbSet<Payment> Payments => Set<Payment>();
    public DbSet<BookAuthor> BookAuthors => Set<BookAuthor>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<BookAuthor>()
            .HasKey(x => new { x.BookId, x.AuthorId });

        modelBuilder.Entity<BookAuthor>()
            .HasOne(x => x.Book)
            .WithMany(b => b.Authors)
            .HasForeignKey(x => x.BookId);

        modelBuilder.Entity<BookAuthor>()
            .HasOne(x => x.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(x => x.AuthorId);

        modelBuilder.Entity<Book>()
            .HasIndex(b => b.ISBN)
            .IsUnique();
    }
}
