using System.ComponentModel.DataAnnotations;

namespace webanthuc.Request
{
    public class addRoleToUserForm
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string roleName { get; set; }
        
    }
}
