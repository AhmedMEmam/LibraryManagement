namespace LibraryManagement.Application.DTOs;

public record ShelfDto(int Id, string Code, string? Location);
public record ShelfCreateDto(string Code, string? Location);
