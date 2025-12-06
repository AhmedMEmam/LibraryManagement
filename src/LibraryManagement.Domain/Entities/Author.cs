namespace LibraryManagement.Domain.Entities;

public class Author : BaseEntity
{
    public required string Name { get; set; }

    public ICollection<BookAuthor> Books { get; set; } = new List<BookAuthor>();
}
