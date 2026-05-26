# API Documentation

## Auth

### Register

```http
POST /api/auth/register
```

Request:

```json
{
  "username": "minh",
  "email": "minh@gmail.com",
  "password": "123456"
}
```

---

### Login

```http
POST /api/auth/login
```

---

## Posts

### Get Feed

```http
GET /api/posts?page=1&pageSize=10
```

---

### Create Post

```http
POST /api/posts
```

---

### Like Post

```http
POST /api/posts/{id}/like
```

---

## Comments

### Add Comment

```http
POST /api/comments
```

---

## Chat

### SignalR Hub

```http
/chatHub
```