using System;
using System.Collections.Generic;

namespace CentroClinico.Domain.Entities
{
  public class Doctor
  {
    public Guid ID { get; set; } = Guid.NewGuid();
    public string CRM { get; set; }
    public string CPF { get; set; }
    public List<DoctorUnity> Unities { get; set; }
    public List<DoctorSpecialty> Specialties { get; set; }
    public Guid UserID { get; set; }
    public User User { get; set; }
  }
}
