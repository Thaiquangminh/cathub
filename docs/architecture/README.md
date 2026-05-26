# System Architecture

CatHub is a real-time social platform for cat lovers.

The system supports:
- image upload
- realtime chat
- comments
- likes
- notifications

---

# Backend Architecture

The backend follows Clean Architecture principles.

Layers:

## API
Responsible for:
- Controllers
- Middleware
- Authentication
- SignalR hubs

## Application
Responsible for:
- Business logic
- Use cases
- DTOs
- Validation

## Domain
Responsible for:
- Core entities
- Business rules

## Infrastructure
Responsible for:
- AWS S3
- Redis
- JWT
- External integrations

## Persistence
Responsible for:
- EF Core
- PostgreSQL
- Database migrations