using System;

namespace CentroClinico.Domain.Entities
{
  public class DoctorSpecialty
  {
    public Guid ID { get; set; } = Guid.NewGuid();
    public Guid DoctorID { get; set; }
    public Doctor Doctor { get; set; }
    public Guid SpecialtyID { get; set; }
    public Specialty Specialty { get; set; }
  }
}
