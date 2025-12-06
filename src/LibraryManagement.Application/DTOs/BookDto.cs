namespace LibraryManagement.Application.DTOs;

public record BookDto
(
    int Id,
    string Title,
    string ISBN,
    DateOnly PublishedDate,
    int Quantity,
    int CategoryId,
    int PublisherId,
    int ShelfId
);

public record BookCreateDto
(
    string Title,
    string ISBN,
    DateOnly PublishedDate,
    int Quantity,
    int CategoryId,
    int PublisherId,
    int ShelfId
);
