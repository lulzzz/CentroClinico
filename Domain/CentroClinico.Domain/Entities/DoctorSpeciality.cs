using System;

namespace CentroClinico.Domain.Entities
{
  public class DoctorSpeciality
  {
    public Guid DoctorID { get; set; }
    public Doctor Doctor { get; set; }
    public Guid SpecialityID { get; set; }
    public Speciality Speciality { get; set; }
  }
}
