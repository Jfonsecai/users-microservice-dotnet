# Users Microservice (.NET + Clean Architecture + Docker)

Microservicio REST para la gestión de usuarios construido con **.NET**, siguiendo **Clean Architecture**, persistencia con **Entity Framework Core** y base de datos **SQL Server**, completamente **dockerizado**.

Este proyecto fue creado como prueba para servir como plantilla base de futuros microservicios.

---

## 🚀 Tech Stack

- .NET 10 / ASP.NET Core Web API
- Clean Architecture (Domain / Application / Infrastructure / Api)
- Entity Framework Core (Code First + Migrations)
- SQL Server
- Docker & Docker Compose
- Swagger / OpenAPI

---

## 📦 Arquitectura

El proyecto sigue separación de responsabilidades:

src/
│
├── UsersService.Api → Endpoints HTTP, configuración, DI  
├── UsersService.Application → Casos de uso, lógica de negocio  
├── UsersService.Domain → Entidades y reglas de dominio  
├── UsersService.Infrastructure → EF Core, DbContext, repositorios  

### Capas

- **Domain** → entidades puras
- **Application** → lógica del negocio
- **Infrastructure** → acceso a datos
- **Api** → exposición HTTP

Esto facilita:
- mantenibilidad
- testeo
- escalabilidad
- independencia de frameworks

---

## ✨ Features

- CRUD completo de usuarios
- EF Core Migrations
- Creación automática de base de datos (`Database.Migrate()`)
- Swagger UI
- Dockerizado
- Listo para replicar como template de microservicio

---

## ⚙️ Requisitos

Instalar:

- Docker Desktop
- .NET SDK (opcional si usas solo Docker)
- Git

---

## ▶️ Ejecutar con Docker (recomendado)

Desde la raíz del proyecto:

```bash
docker compose up --build
