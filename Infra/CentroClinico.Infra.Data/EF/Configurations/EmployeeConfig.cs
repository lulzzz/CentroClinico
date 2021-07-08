using CentroClinico.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Data.EF.Configurations
{
  public class EmployeeConfig : IEntityTypeConfiguration<Employee>
  {
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
      builder.ToTable("employeies");
      builder.HasKey(x => x.ID);

      builder.Property(x => x.ID)
        .HasColumnName("employee_id")
        .ValueGeneratedOnAdd();

      builder.Property(x => x.CPF)
        .HasColumnName("cpf")
        .HasMaxLength(11)
        .IsRequired();

      builder.Property(x => x.CEP)
        .HasColumnName("cep")
        .HasMaxLength(8)
        .IsRequired();

      builder.Property(x => x.HouseNumber)
        .HasColumnName("house_number")
        .HasMaxLength(10)
        .IsRequired();

      builder.Property(x => x.AdditionalInfo)
        .HasColumnName("additional_info")
        .HasMaxLength(50)
        .IsRequired();

      builder.Property(x => x.UserID)
        .HasColumnName("user_id");

      builder.HasOne(x => x.User);

    }
  }
}

