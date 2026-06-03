namespace CatHub.Domain.Entities;

public class Message
{
    public Guid Id { get; set; }
    public Guid ChatRoomId { get; set; }
    public Guid SenderId { get; set; }
    public string Content { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public ChatRoom ChatRoom { get; set; } = null!;
    public User Sender { get; set; } = null!;
}
