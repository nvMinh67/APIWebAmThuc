using System.ComponentModel.DataAnnotations;

namespace webanthuc.Request
{
    public class SignIn
    {
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
