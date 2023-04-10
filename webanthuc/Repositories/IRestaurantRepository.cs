using Microsoft.AspNetCore.Mvc;
using webanthuc.Model;
using webanthuc.Response;

namespace webanthuc.Repositories
{
    public interface IRestaurantRepository
    {
        Task<List<RestaurantInformation>> getAll();
        Task<RestaurantInformation> get(int id);
        Task<int> add([FromForm]RestaurantModel dish);
        Task<int> update(int id, [FromForm]RestaurantModel dish);
        Task delete(int id);
    }
}
