using webanthuc.Entity;
using webanthuc.Request;

namespace webanthuc.Repositories
{
    public interface IUserRepository
    {
        Task<List<ApplicationUser>> GetAll();
        Task<string> AddRoleToUser(addRoleToUserForm form);
    }
}
