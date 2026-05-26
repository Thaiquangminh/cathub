# CatHub 😺

A real-time social platform for cat lovers.

Users can:
- Upload cat images
- Chat in realtime
- Comment and react
- Follow other users

---

## 🚀 Tech Stack

### Frontend
- React
- Zustand
- React Query

### Backend
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- SignalR

### Infrastructure
- Docker
- Redis
- AWS S3
- AWS SQS
- AWS Lambda
- AWS RDS

---

## 🏗 Architecture

```text
React Frontend
      ↓
ASP.NET Core API
      ↓
PostgreSQL (RDS)

Upload Image
      ↓
S3
      ↓
SQS Event
      ↓
Lambda Resize Image

Realtime Chat
      ↓
SignalR
      ↓
Redis Backplane
```

---

## 📦 Features

- JWT Authentication
- Upload Cat Images
- Infinite Feed
- Realtime Chat
- Redis Cache
- Background Image Processing
- AWS Integration
- Dockerized Development

---

## 📁 Project Structure

```text
cathub/
├── backend/
├── frontend/
├── docs/
│   ├── erd/
│   ├── flow/
│   ├── architecture/
│   ├── api/
│   └── screenshots/
├── docker-compose.yml
└── README.md
```

---

## 🧠 Documentation

- ERD → `docs/erd`
- Flow diagrams → `docs/flow`
- Architecture diagrams → `docs/architecture`
- API docs → `docs/api`

---

## 🐳 Run Locally

```bash
docker compose up
```

---

## ✅ TODO

- [ ] Setup ASP.NET Core API
- [ ] Setup React Frontend
- [ ] Setup PostgreSQL
- [ ] Setup Docker
- [ ] JWT Authentication
- [ ] Upload Image API
- [ ] Feed API
- [ ] Realtime Chat
- [ ] Redis Cache
- [ ] AWS S3 Upload
- [ ] SQS + Lambda Image Processing

---

## 📸 Screenshots

Add screenshots into:
`docs/screenshots`