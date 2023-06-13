using BlazorApp.Validators;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class LoginViewModel
    {
        [Required]
        [Email(ErrorMessage = "Format du mail invalide")]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
