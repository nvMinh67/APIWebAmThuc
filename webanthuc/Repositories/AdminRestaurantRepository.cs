using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using webanthuc.Entity;
using webanthuc.Model;
using webanthuc.Response;

namespace webanthuc.Repositories
{
    public class AdminRestaurantRepository: IAdminRestaurantRepository
    {
        private readonly MyDbContext _context;
        private readonly UserManager<ApplicationUser> _userManger;

        public AdminRestaurantRepository(MyDbContext context,UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManger = userManager;
        }

        public async Task<responeUser> GetAdmin(string id)
        {
            var result = await (from user in _userManger.Users.AsNoTracking()
                               where user.Id == id
                               join d in _context.restaurantDetails on user.Id equals d.id_user
                               join r in _context.Restaurants1 on d.id_restaurant equals r.Id
                                select new responeUser()
                                {
                                    ID = Convert.ToInt32(d.id_restaurant),
                                    Name = r.Name,
                                    dish =  (from me in _context.menus1.AsNoTracking()
                                                   where me.id_restaurant1 == d.id_restaurant
                                                   join di in _context.Dish1s on me.id_dish1 equals di.Id
                                                   select new Dish1()
                                                   {
                                                       Name = di.Name,
                                                       Id = di.Id,
                                                       price = di.price,
                                                       Image_Dishes1 = me.Dish1.Image_Dishes1,

                                                   }).ToList(),
                                }
                             ).FirstOrDefaultAsync();
                               //select new responeUser()
                               //{
                               //    //ID = Convert.ToInt32(d.id_restaurant),
                               //    //Name = user.Id,
                               //}).FirstOrDefault();
            return result;
        }

       

        //public async Task<AdminRestaurantInformation> GetAdmin(string id)
        //{
        //    //var result = await (from u in _userManger.Users.AsNoTracking()
        //    //                    //where u.Id == id
        //    //                    //join de in _context.restaurantDetails on u.Id equals de.id_user
        //    //                    //join re in _context.Restaurants1 on Convert(Int32(de.id_restaurant)) equals Convert(Int32(re.Id) 
        //    //                    select new AdminRestaurantInformation()
        //    //                    {


        //    //                    });
        //    var result = await _userManger.FindByIdAsync(id);
        //    //var infor = new AdminRestaurantInformation()
        //    //{
        //    //    restaurant_Id = result.
        //    //};
        //    //var id_restaurant = await (from u in _userManger.Users.AsNoTracking()
        //    //                           where u.Id == id
        //    //                           join de in _context.restaurantDetails on u.Id equals de.id_user
        //    //                           join re in _context.Restaurants1 on de.id_restaurant equals re.Id
        //    //                           select new AdminRestaurantInformation()
        //    //                           {

        //    //                           }
        //    //      ).FirstOrDefault();
        //    //return id_restaurant ;
        //}


    }
}
