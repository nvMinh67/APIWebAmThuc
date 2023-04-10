using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webanthuc.Entity;
using webanthuc.Repositories;
using webanthuc.Request;

namespace webanthuc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomRepository _roomRepository;

        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        [HttpPost]
        public async Task<IActionResult> createTypeRoom (TypeRoom model)
        {
           var result =  await _roomRepository.createTypeRoom(model);
            if(result == 1)
                return BadRequest(ModelState);
            return Ok(model);
        }
        [HttpPost]
        [Route("/api/CreateARoom")]
        public async Task<IActionResult> createARoom ([FromForm]inforRoom model)
        {
            var room = await _roomRepository.createRoom(model);
            return Ok(room);
        }
        [HttpGet("id")]
        public async Task<IActionResult> getRoom (int id)
        {
          var room = await  _roomRepository.GetRoom(id);
            return Ok(room);
        }
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var rooms = await _roomRepository.GetAllRoom();
            return Ok(rooms);
        }
        [HttpGet("id_hotel")]
        public async Task<IActionResult> getDetailHotel(int id_hotel)
        {
            var hotel = await _roomRepository.GetDetailHotel(id_hotel);
            return Ok(hotel);
        }
        [HttpPost]
        [Route("/api/FilterRoom")]
        public async Task<IActionResult> FilterRoomByDate([FromForm]RequestDateTime model)
        {
            var day = model.EndDate - model.StartDate;
            var result = _roomRepository.FilterRoomByDate(model);
            return Ok(result);
        }
    }
}
