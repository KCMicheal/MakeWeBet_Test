# MakeWeBet_Test
This is an assessment from MakeWeBet platform. 

This project is a .NET Web API application that exposes some endpoints for different functionalities. The project follows the clean architecture principles and uses Entity Framework Core, AutoMapper, Serilog, Swagger and other packages.

## API Endpoints

The API endpoints are documented using Swagger UI, which can be accessed at `/swagger` when the application is running. Some of the endpoints are:

- `/api/users`: For user management operations such as adding user aand paying for products etc.
- `/api/store`: For CRUD operations on stores such as adding store and adding product to a store.

## How to run the project

To run the project, you need to have .NET SDK installed on your machine. You also need to have a SQL Server database and update the connection string in the `appsettings.json` file.

You can use the following commands to run the project:

- `dotnet restore`: To restore the dependencies.
- `dotnet ef database update`: To apply the migrations to the database.
- `dotnet run`: To start the application.

Alternatively, you can also run the project using Docker. You need to have Docker installed and running on your machine. You can use the following commands to build and run a Docker image for the project:

- `docker build -t webapi .`: To build the image with the name `webapi`.
- `docker run -p 5000:80 webapi`: To run the image and map port 5000 to port 80.

## Database design picture

The database design picture is located in the `root` folder of the project. It shows the entity relationships and attributes of the database.
