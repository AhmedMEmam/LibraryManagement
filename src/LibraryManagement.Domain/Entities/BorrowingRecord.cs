namespace LibraryManagement.Domain.Entities;

public class BorrowingRecord : BaseEntity
{
    public int? BookId { get; set; }
    public Book? Book { get; set; }

    public int? MemberId { get; set; }
    public Member? Member { get; set; }

    public DateTime BorrowedAt { get; set; }
    public DateTime DueAt { get; set; }
    public DateTime? ReturnedAt { get; set; }
}
