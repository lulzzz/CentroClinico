using CentroClinico.Domain.Entities;
using CentroClinico.Infra.Data.EF;
using CentroClinico.UI.MVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CentroClinico.UI.MVC.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private EFContext Context { get; set; }

    public HomeController(ILogger<HomeController> logger, EFContext context)
    {
      _logger = logger;
      Context = context;
    }

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }
    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Login(MVLogin login)
    {
      if (ModelState.IsValid)
      {
        User user = Context.Users.FirstOrDefault(x => x.Email == login.Email && x.Password == login.Password);
        if (user == null)
        {
          ModelState.AddModelError("", "Usuario ou senha inválidos");
          return View();
        }

        if (!user.Active)
        {
          ModelState.AddModelError("", "Usuario inativo, por favor verifique seu e-mail");
          return View();
        }

        List<Claim> claims = new List<Claim>
        {
          new Claim(ClaimTypes.Name, user.Email),
          new Claim(ClaimTypes.Role, user.Profile.ToString())
        };

        ClaimsIdentity userIdentity = new ClaimsIdentity(claims, user.Email);
        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);

        AuthenticationProperties authenticationProperties = new AuthenticationProperties
        {
          AllowRefresh = true,
          ExpiresUtc = DateTime.Now.ToLocalTime().AddHours(2),
          IsPersistent = false
        };

        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, authenticationProperties);
        return RedirectToAction("Index", "Home");

      }
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
