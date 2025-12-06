namespace LibraryManagement.Domain.Entities;

public class Payment : BaseEntity
{
    public int MemberId { get; set; }
    public Member? Member { get; set; }

    public decimal Amount { get; set; }
    public DateTime PaidAt { get; set; }
    public string? Description { get; set; }
}
