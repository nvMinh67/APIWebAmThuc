using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webanthuc.Repositories;
using webanthuc.Request;
using webanthuc.Response;

namespace webanthuc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository repo;

        public AccountController(IAccountRepository repo) {
            this.repo = repo;
        }
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp (SignUp model)
        {
            var result = await repo.SignUp(model);
            if (result.Succeeded) {
                return Ok(result.Succeeded);
            }
            return Unauthorized();
        }
        [HttpPost("SignIn")]
        public async Task<IActionResult> SighIn (SignIn model)
        {  
            var result = await repo.SignIn(model);
            if (result == null)
            {
                return Unauthorized(result);
            }
            return Ok(result);
        }
        [HttpPost]
        [Route("signUpAdmin")]
        public async Task<IActionResult> signUpAdmin (AccountAdminRestaurantInformation model)
        {
            var result = await repo.SignUpAdminRestaurant(model);
            if (!result.Succeeded)
            {
                return Unauthorized();
            }
            return Ok(result);
        }
       
        [HttpPost]
        [Route("addRestaurantToAdmin")]
        public async Task<IActionResult> addRestaurantToAdmin(addRestaurantToAdmin model)
        {
            var result = await repo.AddRestaurantToAdmin(model.id_restaurant, model.id_user);
            if (result  == null)
            {
                return  BadRequest(result);
            }
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var result = await repo.getAll();
           
            return Ok(result);
        }
    }
}
