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
          Password = "123456",
          BirthDay = new System.DateTime(1990, 1, 1)
        }); ;
      }

      if (context.Specialities.ToList().Count == 0)
      {
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Acupuncture" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Allergy and Immunology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Anesthesiology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Angiology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "cancerology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Cardiology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Cardiovascular Surgery" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "hand surgery" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Head and Neck Surgery" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Digestive System Surgery" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "General surgery" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Pediatric surgery" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Plastic surgery" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Thoracic surgery" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Vascular surgery" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Medical clinic" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Coloproctology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Dermatology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Endocrinology and Metabolism" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Endoscopy" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Gastroenterology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Medical Genetics" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Geriatrics" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Gynecology and Obstetrics" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Hematology and Hemotherapy" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Homeopathy" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Infectology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "mastology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Family and Community Medicine" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Occupational Medicine" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "traffic medicine" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "sports medicine" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Physical Medicine and Rehabilitation" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Intensive Care" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Forensic Medicine and Medical Expertise" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Nuclear medicine" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Preventive and Social Medicine" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "nephrology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Neurosurgery" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Neurology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Nutrilogy" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Ophthalmology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Orthopedics and Traumatology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Otolaryngology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Pathology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Clinical Pathology/Laboratory Medicine" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Pediatrics" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Pneumology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Psychiatry" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Radiology and Imaging Diagnosis" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Radiotherapy" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Rheumatology" });
        context.Specialities.Add(new Domain.Entities.Speciality { Name = "Urology" });
      }

      context.SaveChanges();
    }
  }
}
