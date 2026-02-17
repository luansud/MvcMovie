# 🎬 MVC Movie

A movie catalog web application built with **ASP.NET Core MVC** and **.NET 10**, demonstrating full CRUD operations and the Model-View-Controller pattern.

## Overview

MvcMovie is a web application that allows users to manage a movie database with features for creating, reading, updating, and deleting movie entries. The project follows Microsoft's official ASP.NET Core MVC tutorial with additional enhancements.

## Tech Stack

- **Framework:** ASP.NET Core MVC (.NET 10)
- **Language:** C#
- **ORM:** Entity Framework Core
- **Database:** SQLite
- **Frontend:** Razor Views, CSS, JavaScript

## Features

- Full CRUD operations for movie records
- Search and filter movies by title and genre
- Data validation with model annotations
- Database migrations with Entity Framework Core
- Responsive UI with Razor Views

## Project Structure
├── Controllers/     # MVC Controllers
├── Models/          # Data models and view models
├── Views/           # Razor view templates
├── Data/            # Database context
├── Migrations/      # EF Core migrations
├── wwwroot/         # Static assets
└── Program.cs       # Application configuration

## Getting Started

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download)

### Run Locally
```bash
git clone https://github.com/luansud/MvcMovie.git
cd MvcMovie
dotnet run
```

## Course

**Microsoft Learn — ASP.NET Core MVC Tutorial** | Completed as part of .NET learning path
