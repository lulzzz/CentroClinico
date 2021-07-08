using CentroClinico.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentroClinico.Infra.Data.EF.Configurations
{
  public class CustomerConfig : IEntityTypeConfiguration<Customer>
  {
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
      builder.ToTable("custumers");
      builder.HasKey(x => x.ID);

      builder.Property(x => x.ID)
        .HasColumnName("custumer_id")
        .ValueGeneratedOnAdd();

      builder.Property(x => x.InsuranceCardNumber)
        .HasColumnName("insurance_card_number")
        .HasMaxLength(16);

      builder.Property(x => x.InsuranceCompany)
        .HasColumnName("insurance_company")
        .HasMaxLength(50);

      builder.Property(x => x.InsurancePlan)
        .HasColumnName("insurance_plan")
        .HasMaxLength(30);

      builder.Property(x => x.UserID)
        .HasColumnName("user_id")
        .IsRequired();

      builder.HasOne(x => x.User);
    }
  }
}
