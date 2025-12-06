namespace LibraryManagement.Application.DTOs;

public record MemberDto(int Id, string FullName, string Email);
public record MemberCreateDto(string FullName, string Email);
