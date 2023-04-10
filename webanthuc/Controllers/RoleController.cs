using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webanthuc.Repositories;

namespace webanthuc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository roleRepository;

        public RoleController(IRoleRepository roleRepository) {
        this.roleRepository = roleRepository;
        }
        [HttpPost]
        public async Task<IActionResult> createRole (string roleName)
        {
            var result = await roleRepository.createRole
                (roleName);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);

        }
    }
}
