# Resilient Banking API

## Project Description

The **Resilient Banking API** is a .NET Core-based Web API designed to demonstrate resilience patterns in a cloud-based banking application. This project showcases various techniques to build robust and fault-tolerant APIs, using patterns such as retry policies and circuit breakers. It also incorporates health checks to ensure the application’s health and stability.

## Technologies Used

- **.NET Core 6.0**: Framework for building the API
- **Polly**: Resilience and transient-fault-handling library
- **Entity Framework Core**: ORM for data access
- **In-Memory Database**: For development and testing purposes
- **Health Checks**: For monitoring the health of the application

-ResilientBankingAPI/
-├── Controllers/
-│   └── AccountController.cs
-├── Models/
-│   └── Account.cs
-├── Services/
-│   ├── IAccountService.cs
-│   └── AccountService.cs
-├── Data/
-│   └── BankingContext.cs
-├── Resilience/
-│   └── ResiliencePolicies.cs
-├── Program.cs
-└── appsettings.json



 

## Setup and Installation

Follow these steps to set up and run the project on your local machine:

1. **Clone the Repository:**
    ```bash
    git clone https://github.com/your-username/ResilientBankingAPI.git
    cd ResilientBankingAPI
    ```

2. **Install Dependencies:**
    ```bash
    dotnet restore
    ```

3. **Run the Application:**
    ```bash
    dotnet run
    ```
    The API will start and be available at `https://localhost:5001` (or another port if configured differently).

## API Usage

### Example Endpoints

| Endpoint                | Method | Description                          | Request Body (for POST/PUT)                 |
|-------------------------|--------|--------------------------------------|---------------------------------------------|
| `/api/accounts`         | `GET`  | Retrieves a list of all accounts      | N/A                                         |
| `/api/accounts`         | `POST` | Creates a new account                 | ```json<br>{<br>  "accountName": "string",<br>  "balance": 0.0<br>}<br>``` |
| `/api/accounts/{id}`    | `GET`  | Retrieves a specific account by ID    | N/A                                         |
| `/api/accounts/{id}`    | `PUT`  | Updates a specific account            | ```json<br>{<br>  "accountName": "string",<br>  "balance": 0.0<br>}<br>``` |
| `/api/accounts/{id}`    | `DELETE` | Deletes a specific account by ID      | N/A                                         |



   ### Explanation:

- **"Additional Resources" Section:** Added a new section to include your Medium article link.
- **Markdown Link:** The link to your Medium article is included in the format `[Medium article](https://medium.com/@neslihanerdem/building-resilient-cloud-applications-with-net-resilience-patterns-e0e01f3f52ac)`.

