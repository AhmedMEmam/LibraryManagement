namespace LibraryManagement.Domain.Entities;

public class Book : BaseEntity
{
    public required string Title { get; set; }
    public required string ISBN { get; set; }
    public DateOnly PublishedDate { get; set; }
    public int Quantity { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    public int PublisherId { get; set; }
    public Publisher? Publisher { get; set; }

    public int ShelfId { get; set; }
    public Shelf? Shelf { get; set; }

    public ICollection<BookAuthor> Authors { get; set; } = new List<BookAuthor>();
    public ICollection<BorrowingRecord> BorrowingRecords { get; set; } = new List<BorrowingRecord>();
}
