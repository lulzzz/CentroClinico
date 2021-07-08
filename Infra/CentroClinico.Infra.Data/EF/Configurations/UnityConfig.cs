using CentroClinico.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Data.EF.Configurations
{
  public class UnityConfig : IEntityTypeConfiguration<Unity>
  {
    public void Configure(EntityTypeBuilder<Unity> builder)
    {

      builder.ToTable("unities");
      builder.HasKey(x => x.ID);

      builder.Property(x => x.ID)
        .HasColumnName("unity_id")
        .ValueGeneratedOnAdd();

      builder.Property(x => x.CEP)
        .HasColumnName("cep")
        .HasMaxLength(8)
        .IsRequired();
    
      builder.Property(x => x.HouseNumber)
        .HasColumnName("house_number")
        .HasMaxLength(15)
        .IsRequired();

      builder.Property(x => x.AdditionalInfo)
        .HasColumnName("additional_info")
        .HasMaxLength(50);

      builder.Property(x => x.City)
        .HasColumnName("city")
        .HasMaxLength(30)
        .IsRequired();
    }
  }
}
