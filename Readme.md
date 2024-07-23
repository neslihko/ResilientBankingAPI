# Resilient Banking API

## Project Description

The **Resilient Banking API** is a .NET Core-based Web API designed to demonstrate resilience patterns in a cloud-based banking application. This project showcases various techniques to build robust and fault-tolerant APIs, using patterns such as retry policies and circuit breakers. It also incorporates health checks to ensure the application’s health and stability.

## Technologies Used

- **.NET Core 6.0**: Framework for building the API
- **Polly**: Resilience and transient-fault-handling library
- **Entity Framework Core**: ORM for data access
- **In-Memory Database**: For development and testing purposes
- **Health Checks**: For monitoring the health of the application

ResilientBankingAPI/
├── Controllers/
│   └── AccountController.cs
├── Models/
│   └── Account.cs
├── Services/
│   ├── IAccountService.cs
│   └── AccountService.cs
├── Data/
│   └── BankingContext.cs
├── Resilience/
│   └── ResiliencePolicies.cs
├── Program.cs
└── appsettings.json



## Setup and Installation

Follow these steps to set up and run the project on your local machine:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/ResilientBankingAPI.git
   cd ResilientBankingAPI
