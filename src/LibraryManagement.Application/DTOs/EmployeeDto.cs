namespace LibraryManagement.Application.DTOs;

public record EmployeeDto(int Id, string FullName, string? Role);
public record EmployeeCreateDto(string FullName, string? Role);
