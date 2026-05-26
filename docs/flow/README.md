# Upload Flow

```text
User Selects Image
        ↓
Frontend Calls Backend
        ↓
Backend Generates Presigned URL
        ↓
Frontend Uploads Directly To S3
        ↓
Save Post Metadata To PostgreSQL
        ↓
SQS Event Triggered
        ↓
Lambda Resizes Image
```

## Benefits

- Better scalability
- Faster uploads
- Lower backend memory usage