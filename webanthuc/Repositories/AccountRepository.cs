using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using webanthuc.Entity;
using webanthuc.Migrations;
using webanthuc.Request;
using webanthuc.Response;

namespace webanthuc.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IConfiguration configuration;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly MyDbContext _context;

        public AccountRepository(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager , IConfiguration configuration,
            RoleManager<IdentityRole> roleManager,MyDbContext context)
        { 
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration= configuration;
            _roleManager = roleManager;
            _context = context;
       
          
        }

        public async Task<RestaurantDetail> AddRestaurantToAdmin(int id_restaurant, string id_adminrestaurant)
        {
 
            var detailRestaurant = new RestaurantDetail()
            {
                id_restaurant = id_restaurant,
                   
                id_user = id_adminrestaurant,
           
            };
             _context.restaurantDetails.Add(detailRestaurant);
            await _context.SaveChangesAsync();
            return detailRestaurant;
        }

        public async Task<List<ApplicationUser>> getAll()
        {
            var result = await userManager.Users.ToListAsync();
            return result;
        }

        //public async Task<List<UserWithRole>> getAll()
        //{

        //    var alluser = await userManager.Users.ToListAsync();


        //        var result = new UserWithRole()
        //        {

        //        };


        //    return ;
        //    //var result = new UserWithRole()
        //    //{
        //    //    Name = alluser.ForEach.ToString(),
        //    //    Roles = userManager.GetRolesAsync(alluser.),
        //    //};


        //}

        public async Task<AccountInformation> SignIn (SignIn model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            if (!result.Succeeded)
            {
                return null;
            }
         
            var user = await userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return null;
            }
            var AuthClaim = new List<Claim>
             {
                 new Claim(ClaimTypes.Email,model.Email),
                 new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
             };
            var authenkey =new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));
            var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires:DateTime.Now.AddMinutes(20),
                claims:AuthClaim,
                signingCredentials:new Microsoft.IdentityModel.Tokens.SigningCredentials(authenkey,
                SecurityAlgorithms.HmacSha512Signature)
                );
            /*new JwtSecurityTokenHandler().WriteToken(token);*/
            var rolename = await userManager.GetRolesAsync(user);
            var info = new AccountInformation()
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                //info = user,
                user = new Model.informationUser()
                {
                    Name = user.UserName,
                    roleName = rolename.ToList(),
                    id=user.Id,
                }
            };
            return info;
        }

         public async Task<IdentityResult> SignUp (SignUp model)
        {
            var user = new ApplicationUser
            {
                firstName = model.firstName,
                lastName = model.lastName,
                Email = model.Email,
                UserName = model.Email,
            };
             await userManager.CreateAsync(user,model.Password);
            var result = await userManager.AddToRoleAsync(user, "User");
            return result;
        }

        public async Task<IdentityResult> SignUpAdmin(AccountAdminRestaurantInformation model)
        {
            var user = new ApplicationUser
            {
                firstName = model.firstName,
                lastName = model.lastName,
                Email = model.Email,
                UserName = model.Email,
            };
            await userManager.CreateAsync(user, model.Password);

            var result = await userManager.AddToRoleAsync(user, "ADMINRESTAURANT");
            return result;
        }

        public Task<IdentityResult> SignUpAdminRestaurant(AccountAdminRestaurantInformation model)
        {
            throw new NotImplementedException();
        }
    }
}
