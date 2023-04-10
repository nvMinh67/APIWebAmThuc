using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
using webanthuc.Entity;
using webanthuc.Model;
using webanthuc.Request;
using webanthuc.Response;

namespace webanthuc.Repositories
{
    public class RoomRepository :IRoomRepository
    {
        private readonly MyDbContext _context;

        public RoomRepository(MyDbContext context) {
            _context = context;
        }

        public async Task<int> createRoom([FromForm] inforRoom model)
        {
            var room1 = new Room1()
            {
                Id_TypeRoom = model.RoomID,
            };
            _context.room1s.Add(room1);
            await _context.SaveChangesAsync();
            var roomDetail = new RoomDetail()
            {
                Id_Room1s = room1.Id,
                Id_Hotels = model.HotelId,
                Price = model.Price,
                Size = model.Size,
                View = model.View,
                IsActived = model.IsActive,
                Capacity = model.capacity,
                Room1 = room1,
            };
            _context.RoomDetail.Add(roomDetail);
            await _context.SaveChangesAsync();

            var getCurrenDirectory = Directory.GetCurrentDirectory();

            foreach (var item in model.Image)
            {
                var path = Path.Combine(getCurrenDirectory, "Upload\\files", item.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await item.CopyToAsync(stream);
                }
                var image = new ImageDetailRoom()
                {

                    Name = "Upload/files/" + item.FileName,
                    Id_Room_Detail = roomDetail.Id,

                };
                _context.ImageDetailRooms.Add(image);
            }
            await _context.SaveChangesAsync();
            return 200;
        }
        public async Task<int> createTypeRoom(TypeRoom model)
        {
            var isRoom = await _context.typeRooms.Where(r => r.Name == model.Name).FirstOrDefaultAsync();
            if (isRoom != null)
            {
                return 1;
            }
            var room = new TypeRoom()
            {
                Name = model.Name,
            };
            _context.typeRooms.Add(room);
            await _context.SaveChangesAsync();
            return 0;
        }

        public async Task<TestDate> FilterRoomByDate([FromForm] RequestDateTime model)
        {
            var date = new TestDate()
            {
                StartDate = model.StartDate,
                EndDate = model.EndDate,
            };
            _context.testDates.Add(date);
            _context.SaveChangesAsync();
           
            return date;
        }

        public async Task<List<resRoomDetail>> GetAllRoom()
        {
            var rooms = await (from dt in _context.RoomDetail.AsNoTracking()
                            join r in _context.room1s on dt.Id_Room1s equals r.Id
                            join ty in _context.typeRooms on r.Id_TypeRoom equals ty.Id
                            select new resRoomDetail()
                            {
                                Id_Hotels = dt.Id_Hotels,
                                Id_Room1s = dt.Id,
                                Name = r.TypeRoom.Name,
                                Price = dt.Price,
                                Size = dt.Size,
                                Hotel = dt.Hotel,
                                Room1 = dt.Room1,
                                View = dt.View,
                                IsActived = dt.IsActived,
                                Capacity = dt.Capacity,
                                Image = (from img in _context.ImageDetailRooms.AsNoTracking()
                                         where img.Id_Room_Detail == dt.Id
                                         select img.Name).ToList(),

                            }).ToListAsync();

            return rooms;
        }
        public async Task<ResHotelRoomInfor> GetDetailHotel(int roomId)
        {
            var room = await (from dt in _context.RoomDetail.AsNoTracking()
                              where dt.Id_Hotels == roomId
                              join h in _context.hotels on dt.Id_Hotels equals h.Id
                              join r in _context.room1s on dt.Id_Room1s equals r.Id
                              join ty in _context.typeRooms on r.Id_TypeRoom equals ty.Id
                              select new ResHotelRoomInfor()
                              {
                                  inforOneHotel = new inforOneHotel()
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
                                                     where de.Id_Hotels == h.Id
                                                     select new InforRoom()
                                                     {
                                                         Room = de.Room1,

                                                     }).ToList(),
                                  },
                                  resRoomDetail = (from dt1 in _context.RoomDetail.AsNoTracking()
                                                   where dt1.Id_Hotels == roomId
                                                   join h1 in _context.hotels on dt1.Id_Hotels equals h1.Id
                                                   join r1 in _context.room1s on dt1.Id_Room1s equals r1.Id
                                                   join ty1 in _context.typeRooms on r1.Id_TypeRoom equals ty1.Id
                                                   select new resRoomDetail()
                                                   {
                                                       Id_Room1s = dt1.Id_Room1s,
                                                       Id_Hotels = dt1.Id_Hotels,
                                                       Name = r1.TypeRoom.Name,
                                                       Price = dt1.Price,
                                                       Size = dt1.Size,
                                                       Hotel = dt1.Hotel,
                                                       Room1 = dt1.Room1,
                                                       View = dt1.View,
                                                       IsActived = dt1.IsActived,
                                                       Capacity = dt1.Capacity,
                                                       Image = (from i1 in _context.ImageDetailRooms.AsNoTracking()
                                                                where i1.Id_Room_Detail == dt1.Id
                                                                select i1.Name).ToList(),
                                                   }).ToList(),

                              }).FirstOrDefaultAsync();
            return room;

        }

        public async Task<ResHotelRoomInfor> GetRoom(int roomId)
        {
            var room = await (from dt in _context.RoomDetail.AsNoTracking()
                              where dt.Id_Room1s==roomId
                              join h in _context.hotels on dt.Id_Hotels equals h.Id
                              join r in _context.room1s on dt.Id_Room1s equals r.Id
                              join ty in _context.typeRooms on r.Id_TypeRoom equals ty.Id
                              select new ResHotelRoomInfor()
                              {
                                  inforOneHotel = new inforOneHotel()
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
                                                     where de.Id_Hotels == h.Id
                                                     select new InforRoom()
                                                     {
                                                         Room = de.Room1,

                                                     }).ToList(),
                                  },
                                  resRoomDetail=(from dt1 in _context.RoomDetail.AsNoTracking()
                                                 where dt1.Id_Room1s == roomId
                                                 join h1 in _context.hotels on dt1.Id_Hotels equals h1.Id
                                                 join r1 in _context.room1s on dt1.Id_Room1s equals r1.Id
                                                 join ty1 in _context.typeRooms on r1.Id_TypeRoom equals ty1.Id
                                                 select new resRoomDetail()
                                  {
                                      Id_Room1s = dt1.Id,
                                      Id_Hotels = dt1.Id_Hotels,
                                      Name = r1.TypeRoom.Name,
                                      Price = dt1.Price,
                                      Size = dt1.Size,
                                      Hotel = dt1.Hotel,
                                      Room1 = dt1.Room1,
                                      View = dt1.View,
                                      IsActived = dt1.IsActived,
                                      Capacity = dt1.Capacity,
                                      Image = (from i1 in _context.ImageDetailRooms.AsNoTracking()
                                               where i1.Id_Room_Detail == dt1.Id
                                               select i1.Name).ToList(),
                                  }).ToList(),

                              }).FirstOrDefaultAsync();
            return room; 
        
        }
    }
}
