using CatHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CatHub.Persistence.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Post> Posts => Set<Post>();
    public DbSet<Comment> Comments => Set<Comment>();
    public DbSet<Reaction> Reactions => Set<Reaction>();
    public DbSet<ChatRoom> ChatRooms => Set<ChatRoom>();
    public DbSet<Message> Messages => Set<Message>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
