# CatHub ERD

## Overview

CatHub is a social platform for cat lovers.

Users can:

- Create an account
- Upload and share cat photos
- React to posts
- Comment on posts
- Chat with other users in real time

---

# Entity Relationship Diagram

```mermaid
erDiagram

    USERS ||--o{ POSTS : creates

    USERS ||--o{ COMMENTS : writes

    USERS ||--o{ REACTIONS : reacts

    USERS ||--o{ MESSAGES : sends

    POSTS ||--o{ COMMENTS : contains

    POSTS ||--o{ REACTIONS : receives

    CHAT_ROOMS ||--o{ MESSAGES : contains

    USERS {
        uuid id PK
        string username
        string email
        string password_hash
        string avatar_url
        datetime created_at
        datetime updated_at
    }

    POSTS {
        uuid id PK
        uuid user_id FK
        string caption
        string image_url
        int reactions_count
        int comments_count
        datetime created_at
        datetime updated_at
    }

    COMMENTS {
        uuid id PK
        uuid post_id FK
        uuid user_id FK
        string content
        datetime created_at
        datetime updated_at
    }

    REACTIONS {
        uuid id PK
        uuid post_id FK
        uuid user_id FK
        string reaction_type
        datetime created_at
    }

    CHAT_ROOMS {
        uuid id PK
        datetime created_at
    }

    MESSAGES {
        uuid id PK
        uuid room_id FK
        uuid sender_id FK
        string content
        datetime created_at
    }
```

---

# Relationships

## User → Posts

A user can create multiple posts.

```text
User (1) -------- (*) Posts
```

---

## User → Comments

A user can write multiple comments.

```text
User (1) -------- (*) Comments
```

---

## User → Reactions

A user can react to multiple posts.

```text
User (1) -------- (*) Reactions
```

---

## Post → Comments

A post can contain multiple comments.

```text
Post (1) -------- (*) Comments
```

---

## Post → Reactions

A post can receive multiple reactions.

```text
Post (1) -------- (*) Reactions
```

---

## ChatRoom → Messages

A chat room can contain multiple messages.

```text
ChatRoom (1) -------- (*) Messages
```

---

## User → Messages

A user can send multiple messages.

```text
User (1) -------- (*) Messages
```

---

# Future Enhancements

The following entities are planned for future releases:

- FOLLOWS
- NOTIFICATIONS
- FILES
- POST_TAGS
- REPORTS
- BLOCKED_USERS
- REFRESH_TOKENS

These tables are intentionally excluded from the initial version to keep the system simple and focused on the core features.

---

# Database

Current database engine:

```text
PostgreSQL
```

Future integrations:

```text
Redis     -> Caching
AWS S3    -> Image Storage
AWS SQS   -> Background Messaging
AWS Lambda -> Image Processing
```