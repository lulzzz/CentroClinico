using System;

namespace CentroClinico.Domain.Entities
{
  public class DoctorUnity
  {
    public Guid ID { get; set; } = Guid.NewGuid();
    public Guid DoctorID { get; set; }
    public Doctor Doctor { get; set; }
    public Guid UnityID { get; set; }
    public Unity Unity { get; set; }
  }
}
