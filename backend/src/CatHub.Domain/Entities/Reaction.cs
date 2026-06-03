namespace CatHub.Domain.Entities;

public class Reaction
{
    public Guid Id { get; set; }
    public Guid PostId { get; set; }
    public Guid UserId { get; set; }
    public string ReactionType { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public Post Post { get; set; } = null!;
    public User User { get; set; } = null!;
}
