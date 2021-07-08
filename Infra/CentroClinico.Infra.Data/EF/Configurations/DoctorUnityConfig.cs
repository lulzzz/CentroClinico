using CentroClinico.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Data.EF.Configurations
{
  public class DoctorUnityConfig : IEntityTypeConfiguration<DoctorUnity>
  {
    public void Configure(EntityTypeBuilder<DoctorUnity> builder)
    {
      builder.ToTable("doctor_unity");
      builder.HasKey(x => new { x.UnityID, x.DoctorID });

      builder.Property(x => x.DoctorID)
        .HasColumnName("doctor_id")
        .IsRequired();

      builder.Property(x => x.UnityID)
        .HasColumnName("unity_id")
        .IsRequired();

      builder.HasOne(x => x.Doctor).WithMany(x => x.Unities).HasForeignKey(x => x.UnityID);
      builder.HasOne(x => x.Unity).WithMany(x => x.Doctors).HasForeignKey(x => x.DoctorID);
    }
  }
}
