namespace LibraryManagement.Application.DTOs;

public record PaymentDto(int Id, int? MemberId, decimal Amount, DateTime PaidAt, string? Description);
public record PaymentCreateDto(int? MemberId, decimal Amount, DateTime PaidAt, string? Description);
