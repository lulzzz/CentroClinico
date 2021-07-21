using CentroClinico.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Data.EF.Configurations
{
  public class DoctorSpecialityConfig : IEntityTypeConfiguration<DoctorSpeciality>
  {
    public void Configure(EntityTypeBuilder<DoctorSpeciality> builder)
    {

      builder.ToTable("doctor_speciality");
      builder.HasKey(x => new { x.DoctorID, x.SpecialityID });

      builder.Property(x => x.DoctorID)
        .HasColumnName("doctor_id")
        .IsRequired();
    
      builder.Property(x => x.SpecialityID)
        .HasColumnName("speciality_id")
        .IsRequired();

      builder.HasOne(x => x.Doctor).WithMany(x => x.Specialties).HasForeignKey(x => x.DoctorID);
      builder.HasOne(x => x.Speciality).WithMany(x => x.Doctors).HasForeignKey(x => x.SpecialityID);

    }
  }
}
