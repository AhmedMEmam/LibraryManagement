# Library Management System API

A clean, RESTful ASP.NET Core Web API following Onion Architecture for managing books, authors, members, employees, and supporting entities in a library. The solution separates concerns into Domain, Application, Infrastructure, and API layers while using Entity Framework Core, SQL Server, AutoMapper, and Swagger.

## Projects
- **LibraryManagement.Domain**: Entity models representing the core library concepts.
- **LibraryManagement.Application**: DTOs, mapping profiles, repository and unit of work abstractions, and reusable CRUD services.
- **LibraryManagement.Infrastructure**: EF Core `DbContext`, repository and unit of work implementations, and dependency injection setup.
- **LibraryManagement.Api**: ASP.NET Core Web API with CRUD controllers, Swagger documentation, and service wiring.

## Running the API
1. Update `appsettings.json` with a valid SQL Server connection string.
2. Restore dependencies and run the API:
   ```bash
   dotnet restore
   dotnet ef database update # optional: apply migrations when created
   dotnet run --project src/LibraryManagement.Api/LibraryManagement.Api.csproj
   ```
3. Navigate to `https://localhost:5001/swagger` (or the configured URL) to explore the API.

## Core Features
- CRUD endpoints for books, categories, authors, publishers, shelves, members, employees, borrowing records, and payments.
- Repository and Unit of Work pattern with EF Core.
- DTO mapping via AutoMapper.
- Swagger/OpenAPI documentation enabled by default.

## Solution Layout
```
LibraryManagement.sln
src/
  LibraryManagement.Domain/
  LibraryManagement.Application/
  LibraryManagement.Infrastructure/
  LibraryManagement.Api/
```
