using System.ComponentModel.DataAnnotations;

namespace Blogify.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is a Required Field")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required Field")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        
    }
}
