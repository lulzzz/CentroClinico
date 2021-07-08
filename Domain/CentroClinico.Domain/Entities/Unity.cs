using System;
using System.Collections.Generic;

namespace CentroClinico.Domain.Entities
{
  public class Unity
  {
    public Guid ID { get; set; } = Guid.NewGuid();
    public string CEP { get; set; }
    public string HouseNumber { get; set; }
    public string AdditionalInfo { get; set; }
    public string City { get; set; }
    public List<Room> Rooms { get; set; }
    public List<Appointment> Appointments { get; set; }
    public List<DoctorUnity> Doctors{ get; set; }
  }
}
