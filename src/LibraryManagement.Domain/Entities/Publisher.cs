namespace LibraryManagement.Domain.Entities;

public class Publisher : BaseEntity
{
    public required string Name { get; set; }

    public ICollection<Book> Books { get; set; } = new List<Book>();
}
