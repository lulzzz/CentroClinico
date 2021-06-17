using System;

namespace CentroClinico.Domain.Entities
{
  public class Room
  {
    public Guid ID { get; set; } = Guid.NewGuid();
    public int Number { get; set; }
    public int Floor { get; set; }
    public Guid UnityID { get; set; }
    public Unity Unity { get; set; }
  }
}
