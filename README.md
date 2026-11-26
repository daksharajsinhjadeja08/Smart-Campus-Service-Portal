# Smart Campus Service Portal

## Project Overview
Smart Campus Service Portal is a web-based application developed using ASP.NET Core MVC. It helps manage student records, campus services, and service requests through a centralized platform.

## Technologies Used
- ASP.NET Core MVC (.NET 10)
- C#
- SQL Server (LocalDB)
- Entity Framework Core
- REST API
- HTML
- JavaScript

## Features
- **Student Management:** Add and view student records.
- **Campus Services:** Add and view available campus services.
- **Service Requests:** Submit service requests and update their status.
- **REST API Integration:** Perform GET, POST, PUT, and DELETE operations.
- **MVC + API Integration:** Retrieve and display campus service data through the API.

## Database
The project uses SQL Server with Entity Framework Core.

Database Name: `SmartCampusDB`

Main Tables:
- Students
- CampusServices
- ServiceRequests

## How to Run the Project
1. Clone or download this repository.
2. Open `SmartCampusPortal.sln` in Visual Studio.
3. Restore the NuGet packages.
4. Ensure SQL Server LocalDB is available.
5. Run the database migrations or update the database.
6. Press **F5** to run the application.

## API Endpoints

| Method | Endpoint | Purpose |
|---|---|---|
| GET | `/api/CampusServiceApi` | Get all services |
| GET | `/api/CampusServiceApi/{id}` | Get service by ID |
| POST | `/api/CampusServiceApi` | Add a service |
| PUT | `/api/CampusServiceApi/{id}` | Update a service |
| DELETE | `/api/CampusServiceApi/{id}` | Delete a service |

## Project Purpose
This project demonstrates the integration of ASP.NET Core MVC, SQL Server database operations, Entity Framework Core, and REST API functionality in a Smart Campus application.

## Developed By
Student Project – Smart Campus Service Portal
