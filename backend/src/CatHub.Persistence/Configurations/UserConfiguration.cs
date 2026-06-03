using CatHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatHub.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Username)
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(x => x.Email)
            .HasMaxLength(255)
            .IsRequired();
        builder.HasIndex(x => x.Email)
            .IsUnique();
        builder.HasIndex(x => x.Username)
            .IsUnique();
    }
}
