using System;

namespace CentroClinico.Domain.Entities
{
  public class Employee
  {
    public Guid ID { get; set; } = Guid.NewGuid();
    public string CPF { get; set; }
    public string CEP { get; set; }
    public string NumberCEP { get; set; }
    public Guid UserID { get; set; }
    public User User { get; set; }
  }
}

