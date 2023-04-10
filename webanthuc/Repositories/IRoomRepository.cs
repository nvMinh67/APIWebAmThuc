using Microsoft.AspNetCore.Mvc;
using webanthuc.Entity;
using webanthuc.Request;
using webanthuc.Response;

namespace webanthuc.Repositories
{
    public interface IRoomRepository
    {
        Task<int> createTypeRoom(TypeRoom model);
        Task<int> createRoom([FromForm]inforRoom model);
        Task<ResHotelRoomInfor> GetRoom(int roomId);
        Task<ResHotelRoomInfor> GetDetailHotel(int roomId);
        Task<List<resRoomDetail>> GetAllRoom();
        Task<TestDate> FilterRoomByDate([FromForm] RequestDateTime model);
    }
}
