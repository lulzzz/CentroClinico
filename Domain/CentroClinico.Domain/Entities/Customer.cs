using System;

namespace CentroClinico.Domain.Entities
{
  public class Customer
  {
    public Guid ID { get; set; } = Guid.NewGuid();
    public string InsuranceCardNumber { get; set; }
    public string InsuranceCompany { get; set; }
    public string InsurancePlan { get; set; }
    public Guid UserID { get; set; }
    public User User { get; set; }
  }
}
