using Microsoft.AspNetCore.Identity;
using webanthuc.Entity;
using webanthuc.Request;
using webanthuc.Response;

namespace webanthuc.Repositories
{

    public interface IAccountRepository
    {
        Task<IdentityResult> SignUp(SignUp model);
        Task<AccountInformation> SignIn(SignIn model);
        Task<IdentityResult> SignUpAdminRestaurant(AccountAdminRestaurantInformation model);
        Task<List<ApplicationUser>> getAll();
        Task<RestaurantDetail> AddRestaurantToAdmin(int id_restaurant, string id_adminrestaurant);
    }

}
