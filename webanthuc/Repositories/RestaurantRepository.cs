using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webanthuc.Entity;
using webanthuc.Model;
using webanthuc.Response;

namespace webanthuc.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly MyDbContext _context;
        public RestaurantRepository (MyDbContext context) {
            _context = context;
        }
        public async Task<int> add ([FromForm] RestaurantModel dish)
        {
            try
            {
                var restaurant = new Restaurant1
                {

                    Name = dish.Name,
                    Phone = dish.Phone,
                    about = dish.about,
                    Email =dish.Email,
                    Mapdata = dish.Mapdata,
                    capacity = dish.capacity,
                };
                _context.Restaurants1.Add(restaurant);
                await _context.SaveChangesAsync();
                var getCurrenDirectory = Directory.GetCurrentDirectory();

                foreach (var item in dish.ImageUpload)
                {
                    var path = Path.Combine(getCurrenDirectory, "Upload\\files", item.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await item.CopyToAsync(stream);
                    }
                    var image = new Image_restaurant1()
                    {
                        IdRestaurant1 = restaurant.Id,
                        Name = "Upload/files/" + item.FileName,
                    };
                    _context.Image_Restaurant1s.Add(image);
                }
                await _context.SaveChangesAsync();
                return Convert.ToInt32(restaurant.Id);
            }
            catch
            {
                return 400;
            }
            


        }

        public Task delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<RestaurantInformation> get(int id)
        {
            var disListCach2 = await (from r in _context.Restaurants1.AsNoTracking()

                                      join m in _context.menus1 on r.Id equals m.id_restaurant1
                                      join de in _context.DetailContacts on r.Id equals de.Id
                                      join co in _context.Contacts on de.id_Contact equals co.Id
                                      join wa in _context.Wards on co.id_Ward equals wa.Id
                                      join di in _context.Districts on wa.id_District equals di.Id
                                      join ci in _context.Cities on di.id_City equals ci.Id
                                      where r.Id == id

                                      select new RestaurantInformation()
                                      {
                                          name = r.Name,
                                          Phone = r.Phone,
                                          about = r.about,
                                          Mapdata = r.Mapdata,
                                          Email = r.Email,
                                          address = co.Name,
                                          ward = wa.Name,
                                          city = ci.Name,
                                          district = di.Name,

                                          capacity = r.capacity,

                                          image = (from img in _context.Image_Restaurant1s.AsNoTracking()
                                                   where img.IdRestaurant1 == id
                                                   select img.Name).ToList(),
                                          Dish = (from me in _context.menus1.AsNoTracking()
                                                  where me.id_restaurant1 == id
                                                  select me.Dish1.Name).ToList(),


                                      }).FirstOrDefaultAsync();
            //Dish = (from d1 in _context.Dish1s.AsNoTracking()
            //        where d1.Id 
            //        select img.Name).ToList(),

            return disListCach2;

        }

      

        Task IRestaurantRepository.delete(int id)
        {
            throw new NotImplementedException();
        }

  

           async Task<List<RestaurantInformation>> IRestaurantRepository.getAll()
        {
            

            var disListCach2 = await (from r in _context.Restaurants1.AsNoTracking()

                                      join m in _context.menus1 on r.Id equals m.id_restaurant1
                                      join de in _context.DetailContacts on r.Id equals de.Id
                                      join co in _context.Contacts on de.id_Contact equals co.Id
                                      join wa in _context.Wards on co.id_Ward equals wa.Id
                                      join di in _context.Districts on wa.id_District equals di.Id
                                      join ci in _context.Cities on di.id_City equals ci.Id

                                      select new RestaurantInformation()
                                      {
                                          name = r.Name,
                                          Phone = r.Phone,
                                          about = r.about,
                                          Mapdata = r.Mapdata,
                                          Email = r.Email,
                                          capacity = r.capacity,
                                          address = co.Name,
                                          ward =wa.Name,
                                          city = ci.Name,
                                          district = di.Name,

                                          image = (from img in _context.Image_Restaurant1s.AsNoTracking()
                                                   where img.IdRestaurant1 == r.Id
                                                   select img.Name).ToList(),
                                          Dish = (from me in _context.menus1.AsNoTracking()
                                                 where me.id_restaurant1 == r.Id
                                                 select me.Dish1.Name).ToList(),


        }).ToListAsync();
            //Dish = (from d1 in _context.Dish1s.AsNoTracking()
            //        where d1.Id 
            //        select img.Name).ToList(),

            return disListCach2;

        }

        Task<int> IRestaurantRepository.update(int id, RestaurantModel dish)
        {
            throw new NotImplementedException();
        }
    }

    

        //public async Task<List<RestaurantInformation>> IRestaurantRepository.getAll()
        //{
        //    var disListCach = (from m in _context.menus1.AsNoTracking()
        //                       join d in _context.Dish1s on m.id_dish1 equals d.Id
        //                       select new restaurantDish()
        //                       {
        //                           id_restaurant = Convert.ToInt32(m.id_restaurant1),
        //                           name = d.Name,
        //                       }).ToList();

        //    var disListCach2 = await(from r in _context.Restaurants1.AsNoTracking()

        //                             join m in _context.menus1 on r.Id equals m.id_restaurant1

        //                             select new RestaurantInformation()
        //                             {
        //                                 name = r.Name,
        //                                 Phone = r.Phone,
        //                                 about = r.about,
        //                                 Mapdata = r.Mapdata,
        //                                 Email = r.Email,
        //                                 capacity = r.capacity,

        //                                 image = (from img in _context.Image_Restaurant1s.AsNoTracking()
        //                                          where img.IdRestaurant1 == r.Id
        //                                          select img.Name).ToList(),
        //                                 Dish = (from di in disListCach where di.id_restaurant == r.Id select di.name).ToList()
        //                             }).ToListAsync();
        //    //Dish = (from d1 in _context.Dish1s.AsNoTracking()
        //    //        where d1.Id 
        //    //        select img.Name).ToList(),

        //    return disListCach2;
        //}
    
}
