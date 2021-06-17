using System;

namespace CentroClinico.Domain.Entities
{
  public class Appointment
  {
    public Guid ID { get; set; } = Guid.NewGuid();
    public DateTime DateTime { get; set; }
    public Guid DoctorID { get; set; }
    public Doctor Doctor { get; set; }
    public Guid UnityID { get; set; }
    public Unity Unity { get; set; }
    public Guid CustomerID { get; set; }
    public Customer Customer { get; set; }

  }
}
