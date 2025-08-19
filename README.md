# BookHive - University Library Management System 📚

A comprehensive university library management system built with C# and SQL Server, designed to streamline library operations for administrators and students.

## 🎯 Project Overview

BookHive is a full-stack library management application developed as part of a database systems course. The project demonstrates the complete software development lifecycle from conceptual database design to implementation of a functional application with a user-friendly interface.

## ✨ Features

### Core Functionalities
- **User Management**
  - New user registration (Admin/Student roles)
  - User profile updates and management
  - Role-based access control

- **Book Management**
  - Add new books to the library catalog (Admin only)
  - Update book details and information (Admin only)
  - Advanced book search with multiple criteria (ISBN, author, publication year, etc.)
  - Browse complete book catalog

- **Library Operations**
  - Book borrowing and return system
  - Real-time availability tracking
  - User borrowing history

### Advanced Features
- **Reporting System** 📊
  - Generate meaningful library reports
  - Usage statistics and analytics
  - Borrowing trends analysis

- **Modern GUI** 🖥️
  - Intuitive user interface
  - Responsive design
  - User-friendly navigation

## 🏗️ System Architecture

### Database Design
- **Conceptual ERD**: High-level entity relationships and business rules
- **Physical ERD**: Detailed database schema with data types and constraints
- **Entities**: 5+ main entities with complex relationships
- **Relationships**: Includes many-to-many relationships and weak entities
- **Keys**: Clearly defined primary keys, foreign keys, and referential integrity

### Technology Stack
- **Backend**: C# .NET
- **Database**: Microsoft SQL Server
- **Frontend**: Windows Forms/WPF (GUI implementation)
- **Data Access**: ADO.NET/Entity Framework

## 🗄️ Database Operations

The application implements comprehensive CRUD operations:

### Insert Operations
- Add new users to the system
- Register new books in the catalog

### Update Operations
- Modify user information and profiles
- Update book details and metadata

### Delete Operations
- Remove users from the system (with conditions)
- Archive or remove books from catalog (with conditions)

### Query Operations
- **Simple Queries**: Retrieve data from individual tables
- **Complex Queries**: Multi-table joins for comprehensive data retrieval
- **Advanced Search**: Filter and search across multiple criteria

## 📋 Project Phases

### Phase 1: Database Design ✅
- [x] Conceptual ERD creation
- [x] Entity identification (5+ entities)
- [x] Relationship mapping (including many-to-many)
- [x] Weak entity implementation
- [x] Primary/Foreign key definition

### Phase 2: Implementation ✅
- [x] Physical ERD conversion
- [x] SQL Server database creation
- [x] Data population
- [x] C# application development
- [x] CRUD operations implementation
- [x] GUI development
- [x] Report generation

## 🚀 Getting Started

### Prerequisites
- Microsoft SQL Server
- Visual Studio or .NET SDK
- .NET Framework/Core

### Installation
1. Clone the repository
   ```bash
   git clone https://github.com/Rojeh-wael/BookHive.git
   ```

2. Set up the database
   - Execute the SQL scripts in `/Database` folder
   - Update connection string in `app.config`

3. Build and run the application
   ```bash
   dotnet build
   dotnet run
   ```

## 📁 Project Structure
```
BookHive/
├── Database/
│   ├── ConceptualERD/
│   ├── PhysicalERD/
│   └── SQLScripts/
├── Application/
│   ├── Models/
│   ├── Views/
│   ├── Controllers/
│   └── Database/
├── Documentation/
└── README.md
```

## 🎓 Academic Context

This project was developed as part of a database systems course, focusing on:
- Database design principles
- Entity-Relationship modeling
- SQL Server implementation
- Application development with database integration
- Software engineering best practices

## 📊 Key Learning Outcomes

- **Database Design**: From conceptual modeling to physical implementation
- **SQL Proficiency**: Complex queries, joins, and database operations
- **Application Development**: Integrating database systems with user applications
- **Software Architecture**: Multi-tier application design
- **Project Management**: Structured development phases and deliverables

## 🤝 Contributing

This is an academic project, but feedback and suggestions are welcome! Please feel free to:
- Report issues
- Suggest improvements
- Share your thoughts on the implementation

## 📄 License

This project is developed for educational purposes. Please ensure proper attribution when referencing or building upon this work.

## 🔗 Inspiration

Inspired by real-world library management systems like Stanford University Libraries, this project aims to capture the essential functionalities needed for modern academic library operations.

---

**Note**: This project demonstrates academic work in database systems and software development. The implementation showcases both theoretical knowledge and practical application skills in database-driven software development.