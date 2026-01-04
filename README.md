# ObjectOrientedTest

# ObjectOrientedTest Repository Manager

This solution implements an in-memory repository manager for JSON and XML content
as a C# Class Library.

## Key Features
- Strongly-typed design
- Thread-safe in-memory storage
- Extensible architecture
- SOLID principles applied

## Projects
- ObjectOrientedTest  
  Core class library implementation.

- Formulatrix.Repository.Tests  
  Unit tests using MSTest.

## Notes
- The library is not executable by design.
- Unit tests demonstrate usage and validate behavior.

## Structure
ObjectOrientedTest.Submission
│
├── README.md
│
├── TestScenarios.md
│
├── ObjectOrientedTest
│   ├── ObjectOrientedTest.csproj
│   ├── RepositoryManager.cs
│   │
│   ├── Enums
│   │   └── ItemType.cs
│   │
│   ├── Interfaces
│   │   ├── IItemContent.cs
│   │   ├── IRepositoryStorage.cs
│   │   └── IContentValidator.cs
│   │
│   ├── Contents
│   │   ├── JsonItemContent.cs
│   │   └── XmlItemContent.cs
│   │
│   ├── Storage
│   │   └── InMemoryRepositoryStorage.cs
│   │
│   └── Validators
│       └── DummyContentValidator.cs
│
└── ObjectOrientedTest.Tests
    ├── ObjectOrientedTest.Tests.csproj
    ├── RepositoryManagerTests.cs
    └── Properties 
