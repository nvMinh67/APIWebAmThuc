using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webanthuc.Entity;
using webanthuc.Request;

namespace webanthuc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly MyDbContext _context;

        public DishController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var Dish = _context.dishes.ToList();

            return Ok(Dish);
        }
        [HttpGet("{id}")]
        public IActionResult GetbyID(int id)
        {
            var Dish = _context.dishes.SingleOrDefault(lo => lo.Id == id);
            if (Dish == null)
            {
                return NotFound();
            }

            return Ok(Dish);
        }
        private async Task<bool> writeFile(IFormFile file)
        {
            bool issave = false;
            string filename;
            try
            {
                var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                filename = DateTime.Now.Ticks + extension;
                var partBuilt = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\files");
                if (!Directory.Exists(partBuilt))
                {
                    Directory.CreateDirectory(partBuilt);

                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\files", filename);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                issave = true;
            }
            catch (Exception ex)
            {

            }
            return issave;


        }
        [HttpPost]
        public async Task<IActionResult> createNew([FromForm] RequestDish request)
        {

            var dish = new Dish()
            {
                Name = request.name,
            };
            _context.dishes.Add(dish);
            var restaurant = new Restaurant()
            {
                Name = request.name,
                Phone = request.name,
                Mapdata = request.name,
                about = request.name,
                Email = request.name,

            };
            //_context.Add(restaurant);
            //_context.SaveChanges();
            var menu = new Menu
            {
                id_dish = dish.Id,
                price = request.price,
                id_restaurant = restaurant.Id,

            };
            _context.menus.Add(menu);

            var getCurrenDirectory = Directory.GetCurrentDirectory();

            foreach (var item in request.ImageUploads)
            {
                var path = Path.Combine(getCurrenDirectory, "Upload\\files", item.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await item.CopyToAsync(stream);
                }
                var image = new Image_Dish()
                {
                    IdDish = dish.Id,
                    Name = "/files/" + item.FileName,
                };
                _context.images_dishes.Add(image);
            }
            
           
            //_context.SaveChanges();

            return Ok(request);





        }
        [HttpPut("{id}")]
        public IActionResult updateById(int id, RequestDish request)
        {
            var dish = _context.dishes.SingleOrDefault(d => d.Id == id);
            if (dish == null)
            {
                return NotFound();
            }
            dish.Name = request.name;
            //_context.SaveChanges();
            return NoContent();
        }
    }
}
