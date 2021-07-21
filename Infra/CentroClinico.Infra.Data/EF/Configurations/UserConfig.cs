using CentroClinico.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Data.EF.Configurations
{
  public class UserConfig : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
      builder.ToTable("users");
      builder.HasKey(x => x.ID);

      builder.Property(x => x.ID)
        .HasColumnName("user_id")
        .ValueGeneratedOnAdd();

      builder.Property(x => x.Name)
        .HasColumnName("name")
        .HasMaxLength(60)
        .IsRequired();

      builder.Property(x => x.Email)
        .HasColumnName("email")
        .HasMaxLength(255)
        .IsRequired();
    
      builder.Property(x => x.Password)
        .HasColumnName("password")
        .HasMaxLength(255)
        .IsRequired();
    
      builder.Property(x => x.Phone)
        .HasColumnName("phone")
        .HasMaxLength(12)
        .IsRequired();
    
      builder.Property(x => x.Profile)
        .HasColumnName("profile")
        .IsRequired();

      builder.Property(x => x.Active)
        .HasColumnName("active")
        .IsRequired();
    }
  }
}

