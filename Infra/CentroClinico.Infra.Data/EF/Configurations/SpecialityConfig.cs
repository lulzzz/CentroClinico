using CentroClinico.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Data.EF.Configurations
{
  public class SpecialityConfig : IEntityTypeConfiguration<Speciality>
  {
    public void Configure(EntityTypeBuilder<Speciality> builder)
    {
      builder.ToTable("specialties");
      builder.HasKey(x => x.ID);


      builder.Property(x => x.ID)
        .HasColumnName("speciality_id")
        .ValueGeneratedOnAdd();

      builder.Property(x => x.Name)
        .HasColumnName("name")
        .HasMaxLength(50);
    }
  }
}
