using System.ComponentModel.DataAnnotations;

namespace webanthuc.Request
{
    public class SignUp
    {
        [Required]
        public string firstName { get; set; } = null!;
        [Required]
        public string lastName { get; set; } = null!;

        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ComfirmPassword { get; set; } 


    }
}
