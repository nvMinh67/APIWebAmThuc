using Microsoft.AspNetCore.Mvc;
using webanthuc.Entity;
using webanthuc.Model;

namespace webanthuc.Repositories
{
    public interface IDishRepository
    {
        Task<List<DishInformation>> getAll();
        Task<DishInformation>get(int id);
        Task<int>add([FromForm]DishModel dish);
        Task<int> update(int id,[FromForm]DishModel dish);
        Task<int> delete(int id);


    }
}
