using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webanthuc.Model;
using webanthuc.Repositories;
using webanthuc.Request;

namespace webanthuc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository) {
            _contactRepository = contactRepository;
        }
        [HttpPost]
        public async Task<IActionResult> create(int id,AddAddress address)
        {
            var newAddress = await _contactRepository.CreateAsync(address, id);
            return Ok(id);
        }
    }
}
