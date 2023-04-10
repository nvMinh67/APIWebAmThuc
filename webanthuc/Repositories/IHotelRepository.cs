using Microsoft.AspNetCore.Mvc;
using webanthuc.Entity;
using webanthuc.Model;
using webanthuc.Request;

namespace webanthuc.Repositories
{
    public interface IHotelRepository
    {
        Task<int> Create([FromForm]HotelInformation model);
        Task<inforOneHotel> GetHotel(int id);
        Task<List<inforHotel>> GetAllHotel();
    }
}
