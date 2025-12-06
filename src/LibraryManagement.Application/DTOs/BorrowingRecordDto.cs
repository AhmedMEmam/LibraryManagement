namespace LibraryManagement.Application.DTOs;

public record BorrowingRecordDto(int Id, int BookId, int MemberId, DateTime BorrowedAt, DateTime DueAt, DateTime? ReturnedAt);
public record BorrowingRecordCreateDto(int BookId, int MemberId, DateTime BorrowedAt, DateTime DueAt, DateTime? ReturnedAt);
