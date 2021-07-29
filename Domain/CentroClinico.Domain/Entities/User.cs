using CentroClinico.Domain.Enums;
using System;

namespace CentroClinico.Domain.Entities
{
  public class User
  {
    public Guid ID { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public EnumProfile Profile { get; set; } = EnumProfile.Custumer;
    public bool Active { get; set; } = true;
    public DateTime BirthDay { get; set; }
  }
}

