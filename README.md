# Person API

This project is a simple API to learn how to create an API and database connection using .NET 8 and Entity Framework Core. The API is built using Minimal API with RESTful principles, allowing you to perform CRUD operations on a `Person` entity.


## Technologies Used

- .NET 8
- Entity Framework Core 9.0.1
- SQLite
- Swagger (Swashbuckle.AspNetCore)

## API Endpoints

- `POST /person` - Create a new person
- `GET /person` - Get all persons
- `PUT /person/{id}` - Update a person by ID
- `DELETE /person/{id}` - Delete a person by ID

## Project Structure

- `Person/Models/PersonModel.cs` - Defines the `PersonModel` class.
- `Person/Data/PersonContext.cs` - Defines the `PersonContext` class for Entity Framework Core.
- `Person/Routes/PersonRoute.cs` - Defines the API routes for the `Person` entity.
- `Person/Program.cs` - Configures and runs the application.

## Learning Objectives

- Understand how to create a simple API using .NET 8.
- Learn how to connect to a database using Entity Framework Core.
- Learn how to perform CRUD operations using Entity Framework Core.
- Explore API documentation using Swagger.
- Learn how to build a Minimal API with RESTful principles.

## Acknowledgements

- [YouTube Video: Building a RESTful API with ASP.NET Core and Entity Framework Core](https://www.youtube.com/watch?v=UXMKOgmQ7zI)
- [Microsoft Documentation](https://docs.microsoft.com/en-us/dotnet/)
- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/)
- [Swagger Documentation](https://swagger.io/docs/)

## Tags

#dotnet #api #entityframework #sqlite #swagger #learning #tutorial #csharp #webapi #aspnetcore #minimalapi #restfulapi

