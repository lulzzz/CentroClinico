using CentroClinico.Infra.Data.EF;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace CentroClinico.UI.MVC
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = CreateHostBuilder(args).Build();
      CreateDbIfNotExists(host);
      host.Run();
    }

    private static void CreateDbIfNotExists(IHost host)
    {
      using (var scope = host.Services.CreateScope())
      {

        IServiceProvider services = scope.ServiceProvider;
        EFContext context = null;
        try
        {
          context = services.GetRequiredService<EFContext>();
          if (!context.Database.EnsureCreated())
          {
            context.Database.Migrate();
          }

        }
        catch (Exception ex)
        {
          var logger = services.GetRequiredService<ILogger<Program>>();
          logger.LogError(ex, "An error occurred creating the DB.");
        }
        SEED.PopulateDatabase(context);
      }
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}
