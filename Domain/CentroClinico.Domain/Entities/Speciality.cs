using System;
using System.Collections.Generic;

namespace CentroClinico.Domain.Entities
{
  public class Speciality
  {
    public Guid ID { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public List<DoctorSpeciality> Doctors{ get; set; }
    public List<Appointment> Appointments{ get; set; }
  }
}
