using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webanthuc.Entity;
using webanthuc.Migrations;
using webanthuc.Model;
using webanthuc.Request;

namespace webanthuc.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly MyDbContext _context;

        public HotelRepository(MyDbContext context) { 
        _context = context;
        }

        public async Task<int> Create([FromForm] HotelInformation model)
        {
            var hotel = new Hotel()
            {
                Name = model.Name,
                Address = model.Address,
                MapData = model.Mapdata,
                Email = model.Email,
                Phone = model.Phone,

            };
            _context.hotels.Add(hotel);
            await _context.SaveChangesAsync();
            if (hotel == null)
            {
                return 400;
            }
            var getCurrenDirectory = Directory.GetCurrentDirectory();

            foreach (var item in model.ImageUploads)
            {
                var path = Path.Combine(getCurrenDirectory, "Upload\\files", item.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await item.CopyToAsync(stream);
                }
                var image = new Entity.Image_Hotel()
                {
                    id_Hotel = hotel.Id,
                    Name = "Upload/files/" + item.FileName,
                    Hotel = hotel,
                };
                _context.Image_Hotel.Add(image);
            }
            await _context.SaveChangesAsync();
            return 200;

        }

        public async Task<List<inforHotel>> GetAllHotel()
        {
            var listHotel = await (from h in _context.hotels
                         
                                   select new inforHotel()
                                   {
                                       Name = h.Name,
                                       Address = h.Address,
                                       Mapdata = h.MapData,
                                       Email = h.Email,
                                       Phone = h.Phone,
                                       //ImageUploads = (from img1 in _context.Image_Hotel1s where img1.Id_Hotel == h.Id
                                       //                select img.Name).ToListAsync(),
                                       Image = (from im in _context.Image_Hotel.AsNoTracking()
                                                where im.id_Hotel == h.Id
                                                select im.Name).ToList(),
                                       //(from i in _context.Image_Hotel1s.AsNoTracking() 
                                       //                where i.Id_Hotel == h.Id
                                       //                select i.Name).ToList(),
                                   }).ToListAsync();
            return listHotel;
        }

        public async Task<inforOneHotel> GetHotel(int id)
        {

            var hotel = await (from h in _context.hotels.AsNoTracking()
                               where h.Id == id
                               select new inforOneHotel()
                               {
                                   Name = h.Name,
                                   Address = h.Address,
                                   Mapdata = h.MapData,
                                   Email = h.Email,
                                   Phone = h.Phone,
                          
                                   Image = (from i in _context.Image_Hotel
                                            where h.Id == i.id_Hotel
                                            select i.Name).ToList(),
                                   Roomdetails = (from de in _context.RoomDetail
                                                 where de.Id_Hotels == id
                                                  select new InforRoom()
                                                  {
                                                      Room = de.Room1,
                                                   
                                                  }).ToList(),
                               }).FirstOrDefaultAsync();

            return hotel;

        }
    }
}
