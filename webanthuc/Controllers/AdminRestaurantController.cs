using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webanthuc.Repositories;
namespace webanthuc.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class AdminRestaurantController : ControllerBase
    {
        private readonly IAdminRestaurantRepository _repo;
        public AdminRestaurantController(IAdminRestaurantRepository repo)
        {
            _repo =  repo;
        }
        [HttpGet("id")]
        public async Task<IActionResult> Get(string id)
        {
            var result = await _repo.GetAdmin(id);

            return Ok(result);
        }

    }
}
