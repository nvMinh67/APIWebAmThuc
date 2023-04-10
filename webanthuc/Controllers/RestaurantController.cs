using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webanthuc.Model;
using webanthuc.Repositories;
using webanthuc.Response;

namespace webanthuc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantController(IRestaurantRepository iRestaurantRepository) {
            _restaurantRepository = iRestaurantRepository; }

        [HttpPost]
        public async Task<IActionResult> add ([FromForm]RestaurantModel restaurant)
        {
            var result = await _restaurantRepository.add(restaurant); 
            if(result == 400)
            {
                return BadRequest(result);

            }
            return Ok(result);
            
        }
        [HttpGet]
        public async Task<IActionResult>getAll()
        {
            var allRestaurant = await _restaurantRepository.getAll();

            return Ok(allRestaurant);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> get(int id)
        {
            var restaurant = await _restaurantRepository.get(id);
            return Ok(restaurant);
            
        }

    }
}
