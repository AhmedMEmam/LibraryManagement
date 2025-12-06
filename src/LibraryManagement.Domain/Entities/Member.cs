namespace LibraryManagement.Domain.Entities;

public class Member : BaseEntity
{
    public required string FullName { get; set; }
    public required string Email { get; set; }

    public ICollection<BorrowingRecord> BorrowingRecords { get; set; } = new List<BorrowingRecord>();
    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
