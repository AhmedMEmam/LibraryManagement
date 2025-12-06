namespace LibraryManagement.Domain.Entities;

public class Employee : BaseEntity
{
    public required string FullName { get; set; }
    public string? Role { get; set; }
}
