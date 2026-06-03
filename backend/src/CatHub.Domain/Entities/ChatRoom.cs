using System.Collections.Generic;

namespace CatHub.Domain.Entities;

public class ChatRoom
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<Message> Messages { get; set; } = new List<Message>();
}
