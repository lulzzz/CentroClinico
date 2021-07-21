using System.ComponentModel.DataAnnotations;

namespace CentroClinico.UI.MVC.Models
{
  public class MVLogin
  {
    [Required(ErrorMessage = "Por favor preencha o email")]
    [DataType(DataType.Text)]
    public string Email { get; set; }

    [Required(ErrorMessage = "Por favor preencha a senha")]
    [MaxLength(10, ErrorMessage = "A senha deve conter no máximo de 10 caracteres")]
    [MinLength(6, ErrorMessage = "A senha deve conter no minimo de 6 caracteres")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
  }
}
