using CentroClinico.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CentroClinico.Infra.Data.EF
{
  public class EFContext : DbContext
  {
    public EFContext() { }
    public EFContext(DbContextOptions<EFContext> options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        string mySQLConnectionStr = "Server=172.31.22.164;Port=3306;Database=CentroClinico;Uid=root;Pwd=root";
        optionsBuilder.UseMySql(mySQLConnectionStr, ServerVersion.AutoDetect(mySQLConnectionStr));
      }
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Unity> Unities { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Employee> Employeies { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<DoctorUnity> DoctorUnities { get; set; }
    public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
  }
}
