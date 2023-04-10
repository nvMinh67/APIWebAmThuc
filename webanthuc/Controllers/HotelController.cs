using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webanthuc.Repositories;
using webanthuc.Request;

namespace webanthuc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelController(IHotelRepository hotelRepository) {
            _hotelRepository = hotelRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create ([FromForm]HotelInformation model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var hotel = await _hotelRepository.Create(model);
            return Ok(hotel);
        }
        [HttpGet("id")]
        public async Task<IActionResult> getHotelById (int id)
        {
            var hotel =await _hotelRepository.GetHotel(id);
            return Ok(hotel);   
        }
        [HttpGet]
        public async Task<IActionResult> getAllHotel()
        {
            var allHotel = await _hotelRepository.GetAllHotel();
            return Ok(allHotel);
        }
    }
}
