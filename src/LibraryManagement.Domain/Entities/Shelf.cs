namespace LibraryManagement.Domain.Entities;

public class Shelf : BaseEntity
{
    public required string Code { get; set; }
    public string? Location { get; set; }

    public ICollection<Book> Books { get; set; } = new List<Book>();
}
