using Microsoft.AspNetCore.Identity;
using webanthuc.Entity;

namespace webanthuc.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleRepository(RoleManager<IdentityRole> roleManager) {
            this.roleManager = roleManager;
        }
        public async Task<string> createRole (string roleName)
        {
            var roleAxist = await roleManager.RoleExistsAsync(roleName);
            if (roleAxist)
            {
                return null;
            }
            var roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
            if (!roleResult.Succeeded)
            {
                return "not succeeded";
            }
            return "succeeded";
            
        }
    }
}
