# 🎓 Student Progress Tracker - Backend Challenge

A modular, scalable backend API to track student progress and analytics, built with **Clean Architecture**, **CQRS**, and **MediatR**.

---

## 🚀 Getting Started
```
dotnet restore
dotnet ef database update --project src/StudentProgress.Infrastructure
dotnet run --project src/StudentProgress.API
```

## 📐 Architecture Overview

- **Clean Architecture / Onion Architecture**:
  - `Domain` – business entities, rules (persistence-agnostic)
  - `Application` – CQRS handlers, services, DTOs, interfaces
  - `Infrastructure` – EF Core, repositories, data access
  - `API` – ultra-thin controllers, MediatR dispatch

- **Patterns & Tools**:
  - CQRS with MediatR (`Commands` & `Queries`)
  - Repository Pattern
  - AutoMapper for DTO mapping
  - Feature folders (Students, Analytics)
  - Dependency Injection throughout

---

## 🛡 Security

- JWT authentication & role-based authorization
- HTTPS enforced
- Parameterized queries (EF Core) to prevent SQL injection
- `TrustServerCertificate=True` used **only in dev**

---

## ⚡ Performance Optimizations

- Paging, filtering & sorting in repositories
- `AsNoTracking()` for read-only queries
- Aggregations (`Average`, `Max`) executed in DB
- DTO projections to avoid loading unnecessary data
- Optionally add caching on analytics endpoints

---

## 🔗 Enterprise Integration

- OpenAPI / Swagger for documentation
- CSV export endpoints

---

## 📈 Scalability & Deployment
- Docker-ready, deployable to Kubernetes / Swarm
- Stateless design → horizontal scaling
- Config per environment via `appsettings.json`
- CI/CD friendly: migrations & seeding are automated

---

## Testing

- Unit tests: services & CQRS handlers (xUnit + Moq)
- Integration tests: controllers via `WebApplicationFactory`
- In-memory DB for fast testing

---

## 🤖 AI & Prompt Engineering

- ChatGPT-assisted code scaffolding:
  - test classes, docs
- Iterative prompts to match Clean Architecture
- AI-assisted README & docs

---

## 📦 Layers Overview

| Layer          | Responsibility                              |
|----------------|---------------------------------------------|
| API            | Controllers, routing, MediatR dispatch      |
| Application    | Use cases, CQRS, services, DTOs, interfaces |
| Domain         | Business entities & rules                   |
| Infrastructure | EF Core context, repositories               |

---

## ✅ Summary

Designed to be:
- **Maintainable**: clean separation of concerns
- **Testable**: unit & integration coverage
- **Scalable**: ready for cloud and containers
- **Secure**: HTTPS, roles
- **Enterprise-ready**: integration, CI/CD, documentation
