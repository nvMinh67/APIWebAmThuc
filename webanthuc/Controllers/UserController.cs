using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using webanthuc.Repositories;
using webanthuc.Request;

namespace webanthuc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository) { 
         _userRepository = userRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() {
        var result =await _userRepository.GetAll();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        [Route("addRoleToUser")]
        public async Task<IActionResult> addRoleToUser (addRoleToUserForm form)
        {
            var result = await _userRepository.AddRoleToUser(form);
            if (result == null)
            {
                return NotFound
                    (result);
            }
            return Ok(result);  
        }
    }
}
