using System;
using System.Collections.Generic;

namespace CatHub.Domain.Entities;

public class Post
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string? Caption { get; set; }
    public string ImageUrl { get; set; } = null!;
    public int ReactionsCount { get; set; }
    public int CommentsCount { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public User User { get; set; } = null!;
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Reaction> Reactions { get; set; } = new List<Reaction>();
}
