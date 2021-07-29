using CentroClinico.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Data.EF.Configurations
{
  public class AppointmentConfig : IEntityTypeConfiguration<Appointment>
  {
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
      builder.ToTable("appointments");
      builder.HasKey(x => x.ID);

      builder.Property(x => x.ID)
        .HasColumnName("appointment_id")
        .ValueGeneratedOnAdd();

      builder.Property(x => x.DateTime)
        .HasColumnName("date_time")
        .IsRequired();

      builder.Property(x => x.DoctorID)
        .HasColumnName("doctor_id");

      builder.Property(x => x.UnityID)
        .HasColumnName("unity_id");

      builder.Property(x => x.CustomerID)
        .HasColumnName("customer_id");

      builder.Property(x => x.SpecialityID)
        .HasColumnName("speciality_id");

      builder.Property(x => x.Private)
        .HasColumnName("private");

      builder.HasOne(x => x.Unity)
        .WithMany(x => x.Appointments)
        .HasForeignKey(x => x.UnityID);

      builder.HasOne(x => x.Speciality)
        .WithMany(x => x.Appointments)
        .HasForeignKey(x => x.SpecialityID);

    }
    
    
    
    
  }
}
