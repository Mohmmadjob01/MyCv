using System.ComponentModel.DataAnnotations;

namespace MyCv.Models.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required]
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
