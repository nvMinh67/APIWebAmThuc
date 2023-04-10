using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using webanthuc.Entity;
using webanthuc.Request;

namespace webanthuc.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _applicationUser;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRepository(UserManager<ApplicationUser> applicationUser,RoleManager<IdentityRole> roleMangager) { 
            _applicationUser = applicationUser;
            _roleManager = roleMangager;
        }

        public async Task<string> AddRoleToUser(addRoleToUserForm form)
        {
            var user = await _applicationUser.FindByEmailAsync(form.Email);
            if (user == null)
            {
                return null;
            }
            var role = await _roleManager.FindByNameAsync(form.roleName);
            if(role == null) {
                return null;
            }
            var result = await _applicationUser.AddToRoleAsync(user, form.roleName);
            if (!result.Succeeded)
            {
                return null;
            }
            return form.Email;



        }

        public async Task<List<ApplicationUser>> GetAll()
        {
            var Userlist = await _applicationUser.Users.ToListAsync();
            if(Userlist == null)
            {
                return new List<ApplicationUser>();
            }
            return Userlist;

        }
    }
}
