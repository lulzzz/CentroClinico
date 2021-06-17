using System;

namespace CentroClinico.Domain.Entities
{
  public class Doctor
  {
    public Guid ID { get; set; }
    public string CRM { get; set; }
    public Guid UserID { get; set; }
    public User User { get; set; }
  }
}
