# CatHub Backend

ASP.NET Core Web API following Clean Architecture principles.

## Architecture

The backend is organized into 5 layers:

- **CatHub.Domain** - Core business entities and rules
- **CatHub.Application** - Business logic, use cases, DTOs, interfaces
- **CatHub.Persistence** - EF Core, Database context, configurations
- **CatHub.Infrastructure** - External services (AWS S3, Redis, JWT)
- **CatHub.API** - Controllers, SignalR hubs, middleware

## Tech Stack

- ASP.NET Core 8.0
- Entity Framework Core 8.0
- PostgreSQL
- Redis
- SignalR (real-time chat)
- JWT Authentication
- AWS S3 (image storage)

## Getting Started

### Prerequisites

- .NET 8.0 SDK
- PostgreSQL
- Redis
- AWS Account (for S3)

### Setup

1. **Restore packages**
   ```bash
   dotnet restore
   ```

2. **Update connection strings**
   
   Edit `CatHub.API/appsettings.json`:
   - PostgreSQL connection string
   - Redis connection string
   - AWS credentials and S3 bucket name
   - JWT secret key

3. **Run migrations**
   ```bash
   cd CatHub.API
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run --project CatHub.API
   ```

The API will be available at `https://localhost:5001`

## Project Structure

```
backend/
├── CatHub.Domain/           # Core entities
│   ├── Entities/
│   │   ├── User.cs
│   │   ├── Post.cs
│   │   ├── Comment.cs
│   │   ├── Like.cs
│   │   └── Chat.cs
│   └── Common/
│       └── BaseEntity.cs
│
├── CatHub.Application/      # Business logic layer
│   ├── DTOs/
│   │   ├── Auth/
│   │   ├── Posts/
│   │   ├── Comments/
│   │   └── Chats/
│   └── Interfaces/
│       ├── IAuthService.cs
│       ├── IPostService.cs
│       ├── ICommentService.cs
│       └── IChatService.cs
│
├── CatHub.Persistence/      # Data access layer
│   ├── Data/
│   │   └── ApplicationDbContext.cs
│   ├── Configurations/
│   │   ├── UserConfiguration.cs
│   │   ├── PostConfiguration.cs
│   │   ├── CommentConfiguration.cs
│   │   ├── LikeConfiguration.cs
│   │   └── ChatConfiguration.cs
│   ├── Repositories/
│   └── Migrations/
│
├── CatHub.Infrastructure/   # External services
│   └── Services/
│       ├── S3Service.cs
│       ├── RedisService.cs
│       └── JwtTokenService.cs
│
└── CatHub.API/             # Web API layer
    ├── Controllers/
    │   ├── AuthController.cs
    │   ├── PostsController.cs
    │   └── CommentsController.cs
    ├── Hubs/
    │   └── ChatHub.cs
    ├── Middleware/
    │   └── ExceptionHandlerMiddleware.cs
    ├── Program.cs
    └── appsettings.json
```

## API Endpoints

### Authentication
- `POST /api/auth/register` - Register new user
- `POST /api/auth/login` - Login user

### Posts
- `GET /api/posts?page=1&pageSize=10` - Get feed
- `POST /api/posts` - Create post (with image upload)
- `POST /api/posts/{id}/like` - Like post
- `DELETE /api/posts/{id}/like` - Unlike post

### Comments
- `POST /api/comments` - Add comment
- `GET /api/comments/post/{postId}` - Get post comments

### Chat (SignalR)
- `/chatHub` - SignalR hub for real-time messaging

## Database Migrations

Create a new migration:
```bash
cd CatHub.API
dotnet ef migrations add MigrationName
```

Apply migrations:
```bash
dotnet ef database update
```

## Next Steps

1. Implement service classes (AuthService, PostService, CommentService, ChatService)
2. Add validation using FluentValidation
3. Implement AutoMapper profiles for DTO mapping
4. Add unit tests
5. Configure AWS S3 and test image uploads
6. Set up Redis for caching
7. Test SignalR real-time chat functionality

## Configuration

Key configuration sections in `appsettings.json`:

- **ConnectionStrings** - PostgreSQL and Redis
- **Jwt** - JWT token configuration
- **AWS** - S3 bucket and credentials
- **AllowedOrigins** - CORS configuration for frontend
