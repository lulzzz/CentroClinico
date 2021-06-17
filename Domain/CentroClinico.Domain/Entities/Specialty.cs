using System;
using System.Collections.Generic;

namespace CentroClinico.Domain.Entities
{
  public class Specialty
  {
    public Guid ID { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public List<Doctor> Doctors { get; set; }
  }
}
