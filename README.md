# User Service Microservice

## Description

This microservice is the first of many for an eCommerce platform. It is built with .NET 8.0 and is responsible for user-related services, including login and registration functionalities.

## Technologies Used

- **.NET**: Version 8.0+
- **Database**: PostgreSQL
- **Architecture**: Clean Architecture, Repository Pattern
- **Containerization**: Support under development and will be available soon.

## Installation

Steps to install the microservice locally.

```sh
# Clone the repository
git clone https://github.com/lauletta/eCommerceSolution.UsersService.git

## Configuration

Environment variables or configuration files required to run the service. The connection string must point to a local database.

## Architecture

This microservice follows the **Clean Architecture** principles, ensuring a clear separation of concerns and maintainability.

### Layers:

- **UI**: Contains controllers, views, view models, filters, and middleware.
- **Core**: Includes business logic services, business logic interfaces, and Data Transfer Objects (DTOs).
- **Domain**: Defines repository interfaces and entity classes.
- **Infrastructure**: Implements repositories, manages database context (DbContext), and handles external API calls.

### Repository Pattern

The **Repository Pattern** is implemented in the **Domain** and **Infrastructure** layers to encapsulate data access logic and provide a clean abstraction for business logic services.

You can refer to the following diagram for a visual representation:


## Project Structure

```
📦 eCommerceSolution.UsersService
 ┣ 📂 eCommerce.API  # Presentation Layer
 ┃ ┣ 📂 Controllers  # API Controllers
 ┃ ┣ 📂 Middlewares  # Middleware components
 ┃ ┣ 📜 appsettings.json  # Configuration file
 ┃ ┣ 📜 Dockerfile  # Docker containerization file
 ┃ ┗ 📜 Program.cs  # Entry point of the application
 ┣ 📂 eCommerce.Core  # Business Logic Layer
 ┃ ┣ 📂 DTO  # Data Transfer Objects
 ┃ ┣ 📂 Entities  # Domain entities
 ┃ ┣ 📂 Mappers  # Data mapping utilities
 ┃ ┣ 📂 RepositoryContracts  # Repository interfaces
 ┃ ┣ 📂 ServiceContracts  # Business service interfaces
 ┃ ┣ 📂 Services  # Business logic implementations
 ┃ ┣ 📂 Validators  # Input validation logic
 ┃ ┗ 📜 DependencyInjection.cs  # Dependency injection configuration
 ┣ 📂 eCommerce.Infrastructure  # Data Access Layer
 ┃ ┣ 📂 DbContext  # Database context
 ┃ ┣ 📂 Repositories  # Repository implementations
 ┃ ┣ 📜 DependencyInjection.cs  # Dependency injection configuration
 ┣ 📜 README.md  # This file
 ┣ 📜 .gitignore  # Git ignore file
 ┗ 📜 .env.example  # Example environment variables
```

## Deployment

Dockerization of the service is currently under development and will be added soon. In the meantime, you can run the service locally.

## Contribution

Guidelines for contributing, reporting issues, or suggesting improvements.

