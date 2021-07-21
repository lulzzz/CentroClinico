using CentroClinico.Domain.Entities;
using CentroClinico.Infra.Data.EF.Configurations;
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
        string mySQLConnectionStr = "Server=banco_mysql;Port=3306;Database=centro_clinico;Uid=root;Pwd=X369408";
        optionsBuilder.UseMySql(mySQLConnectionStr, ServerVersion.AutoDetect(mySQLConnectionStr));
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new AppointmentConfig());
      modelBuilder.ApplyConfiguration(new CustomerConfig());
      modelBuilder.ApplyConfiguration(new DoctorConfig());
      modelBuilder.ApplyConfiguration(new DoctorSpecialityConfig());
      modelBuilder.ApplyConfiguration(new DoctorUnityConfig());
      modelBuilder.ApplyConfiguration(new EmployeeConfig());
      modelBuilder.ApplyConfiguration(new RoomConfig());
      modelBuilder.ApplyConfiguration(new SpecialityConfig());
      modelBuilder.ApplyConfiguration(new UnityConfig());
      modelBuilder.ApplyConfiguration(new UserConfig());
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Unity> Unities { get; set; }
    public DbSet<Speciality> Specialties { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Employee> Employeies { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<DoctorUnity> DoctorUnities { get; set; }
    public DbSet<DoctorSpeciality> DoctorSpecialties { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
  }
}
