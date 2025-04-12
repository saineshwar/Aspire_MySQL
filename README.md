# 🐬 Integrating MySQL with .NET Aspire

This repository demonstrates how to integrate **MySQL** with **.NET Aspire**, a cutting-edge framework for building modern, cloud-native applications with .NET.

## 🚀 What is .NET Aspire?

[.NET Aspire](https://devblogs.microsoft.com/dotnet/introducing-dotnet-aspire/) is a Microsoft-backed framework for developing cloud-native, distributed applications in .NET. It offers out-of-the-box support for:
- Service discovery
- Health checks
- Observability (logs, metrics, tracing)
- Seamless cloud service integration

## 🛢️ Why MySQL?

**MySQL** is one of the most popular open-source relational databases known for:
- High performance and scalability
- Cross-platform support
- Integration with many ORMs like Entity Framework Core

Integrating MySQL with .NET Aspire makes your application portable, reliable, and cloud-ready.

## 📘 Full Tutorial

Read the complete guide here:  
🔗 [Integrating MySQL with .NET Aspire — A Complete Guide](https://tutexchange.com/integrating-mysql-with-net-aspire-a-complete-guide/)

### 📚 What You'll Learn:
- Setting up a MySQL container with .NET Aspire
- Configuring the connection string in Aspire using `builder.AddMySql(...)`
- Using Entity Framework Core with MySQL
- Running database migrations and building APIs

## 🧰 Tech Stack

- .NET 8 / .NET Aspire
- ASP.NET Core
- MySQL (Dockerized)
- Entity Framework Core
- Docker

## 🛠️ Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)
- [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Run the Project

```bash
git clone https://github.com/saineshwar/Aspire_MySQL.git
cd aspire-mysql-integration
dotnet run --project AspireApp
