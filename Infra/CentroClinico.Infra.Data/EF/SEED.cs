using System.Linq;

namespace CentroClinico.Infra.Data.EF
{
  public static class SEED
  {
    public static void PopulateDatabase(EFContext context)
    {
      if (context.Users.ToList().Count == 0)
      {
        context.Users.Add(new Domain.Entities.User
        {
          Active = true,
          Phone = "11999999999",
          Email = "admin@test.com",
          Name = "Admin",
          Profile = Domain.Enums.EnumProfile.Admin,
          Password = "123456"
        });
      }

      context.SaveChanges();
    }
  }
}
