using webanthuc.Model;
using webanthuc.Response;

namespace webanthuc.Repositories
{
    public interface IAdminRestaurantRepository
    {
        Task<responeUser> GetAdmin(string id);
    }
}
