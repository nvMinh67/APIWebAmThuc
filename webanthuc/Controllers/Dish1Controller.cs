using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using webanthuc.Model;
using webanthuc.Repositories;

namespace webanthuc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Dish1Controller : ControllerBase
    {
        private readonly IDishRepository _dishRepository;

        public Dish1Controller(IDishRepository dishRepository)
        { 
            _dishRepository = dishRepository;
        }

        [HttpPost]
        public async Task<IActionResult> addNewDish([FromForm]DishModel dish)
        {
         
                var newDish = await _dishRepository.add(dish);
                return newDish == null ? NotFound() : Ok(newDish);

          
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getDish(int id)
        {
            var dish = await _dishRepository.get(id);
            if (dish == null)
            {
                return NotFound();
            }
            return Ok(dish);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result =await _dishRepository.getAll();
            if (result == null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> update (int id, [FromForm]DishModel dish)
        {
            var result = await _dishRepository.update(id, dish);
            if (result == 400)
            {
                return BadRequest();
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteDish (int id)
        {
            
            var result = await _dishRepository.delete(id);
            if (result == 404)
                return NotFound(id);
            return Ok(id);
        }
    }
}
