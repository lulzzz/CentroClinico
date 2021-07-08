using CentroClinico.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Data.EF.Configurations
{
  public class RoomConfig : IEntityTypeConfiguration<Room>
  {
    public void Configure(EntityTypeBuilder<Room> builder)
    {
      builder.ToTable("rooms");
      builder.HasKey(x => x.ID);

      builder.Property(x => x.ID)
        .HasColumnName("room_id")
        .ValueGeneratedOnAdd();

      builder.Property(x => x.Number)
        .HasColumnName("number")
        .IsRequired();

      builder.Property(x => x.Floor)
        .HasColumnName("floor")
        .IsRequired();

      builder.Property(x => x.UnityID)
        .HasColumnName("unity_id");

      builder.HasOne(x => x.Unity)
        .WithMany(x => x.Rooms)
        .HasForeignKey(x => x.UnityID);
    }
  }
}
