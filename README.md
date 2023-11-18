# .NET 6 Minimal API with Clean Architecture

This repository demonstrates the implementation of a Minimal API using .NET 6 while adhering to Clean Architecture principles for building scalable and maintainable applications.

## Overview

This project aims to showcase a streamlined implementation of a Minimal API, a new feature introduced in .NET 6, while incorporating the following key principles:

- **Minimalism**: Utilizing the Minimal API approach for creating APIs with reduced ceremony and optimized performance.
- **Clean Architecture**: Structuring the application with separation of concerns, promoting maintainability, testability, and scalability.
- **Dependency Injection**: Leveraging .NET's built-in Dependency Injection container for managing object dependencies.
- **Entity Framework Core**: Employing EF Core for data access to interact with the underlying database.
- **CQRS Design pattern**: It uses MediatR to implement CQRS.

## Features

- **Minimal API Endpoints**: Demonstrates how to create HTTP endpoints using the Minimal API syntax.
- **Clean Architecture Layers**: Separation of concerns with distinct layers such as Presentation, Application, Domain, and Infrastructure.
- **Dependency Injection**: Illustrates the use of DI to manage dependencies across different layers.
- **Database Access**: Integrates Entity Framework Core for database interactions.

## Project Structure

The project structure follows a Clean Architecture approach:

- **`Presentation`**: Contains Minimal API endpoints, request/response models, and route configurations.
- **`Core`**: Holds business logic, use cases, and application services.
- **`SharedKernel`**: Defines the shared core domain models, entities, and business rules.
- **`Infrastructure`** 
  - ***`Infrastructure`***: Deals with external concerns like database connection, third-party integrations, external service if any
  - ***`Persistence`***: Repository Helper

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)

### Installation

1. Clone this repository.
   ```bash
   git clone https://github.com/Ashishpote/Net6CleanAPIArchitecture.git
