using System;

namespace CentroClinico.Domain.Entities
{
  public class DoctorUnity
  {
    public Guid DoctorID { get; set; }
    public Doctor Doctor { get; set; }
    public Guid UnityID { get; set; }
    public Unity Unity { get; set; }
  }
}
