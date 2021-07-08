using CentroClinico.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Data.EF.Configurations
{
  public class DoctorConfig : IEntityTypeConfiguration<Doctor>
  {
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
      builder.ToTable("doctors");
      builder.HasKey(x => x.ID);

      builder.Property(x => x.ID)
        .HasColumnName("doctor_id")
        .ValueGeneratedOnAdd();
    
      builder.Property(x => x.CPF)
        .HasColumnName("cpf")
        .HasMaxLength(11)
        .IsRequired();
    
      builder.Property(x => x.CRM)
        .HasColumnName("crm")
        .HasMaxLength(30)
        .IsRequired();

      builder.Property(x => x.UserID)
        .HasColumnName("user_id");

      builder.HasOne(x => x.User);

    }
  }
}
