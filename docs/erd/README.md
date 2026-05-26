# ERD

## Tables

### Users

| Column | Type |
|---|---|
| id | uuid |
| username | varchar |
| email | varchar |
| password_hash | varchar |
| avatar_url | varchar |
| created_at | timestamp |

---

### Posts

| Column | Type |
|---|---|
| id | uuid |
| user_id | uuid |
| image_url | varchar |
| caption | text |
| likes_count | int |
| created_at | timestamp |

---

### Comments

| Column | Type |
|---|---|
| id | uuid |
| post_id | uuid |
| user_id | uuid |
| content | text |
| created_at | timestamp |

---

### Likes

| Column | Type |
|---|---|
| id | uuid |
| user_id | uuid |
| post_id | uuid |

---

### Chats

| Column | Type |
|---|---|
| id | uuid |
| sender_id | uuid |
| receiver_id | uuid |
| message | text |
| created_at | timestamp |

---

## Relationships

```text
Users 1 --- N Posts
Users 1 --- N Comments
Users 1 --- N Likes

Posts 1 --- N Comments
Posts 1 --- N Likes
```