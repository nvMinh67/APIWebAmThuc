using Microsoft.AspNetCore.Identity;

namespace webanthuc.Entity
{
    public class ApplicationUser :IdentityUser
    {
        public string firstName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        

    }
}
