using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TrendBazar.DataAccess.Data;
using TrendBazar.Entities.Dtos;

namespace TrendBazar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetupController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<SetupController> _logger;


        public SetupController(ApplicationContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ILogger<SetupController> logger)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
        }

        // ----------------------------------------------- Users -------------------------------------------------

        [HttpPost]
        [Route("CreateUser")]
        public async Task<IActionResult> Register(RegisterToLoginDto registerToLoginDto)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerToLoginDto.UserName,
                Email = registerToLoginDto.EmailAddress,

            };

            var identityResult = await _userManager.CreateAsync(identityUser, registerToLoginDto.Password);

          
             
                var userClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, registerToLoginDto.EmailAddress),
                    new Claim(ClaimTypes.Name,registerToLoginDto.UserName)
                };

                var addClaimsResult = await _userManager.AddClaimsAsync(identityUser, userClaims);

                var addRolesResult = await _userManager.AddToRolesAsync(identityUser, registerToLoginDto.UserRoles);

                    return Ok("User successfully registered");
                
             

           // return BadRequest("User cannot be registered");
        }


        [HttpGet]
        [Route("GetAllUser")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = _userManager.Users.ToList();
            return Ok(users);
        }


        // ----------------------------------------------- Roles -------------------------------------------------
        
        [HttpGet]
        public IActionResult GetAll() 
        {
            var Manager = _roleManager.Roles.ToList();
            return Ok(Manager);
        }

        [HttpPost]
        [Route("CreateRole")]
        public async Task<IActionResult> CreateRole(string name)
        {
            var Manager =await  _roleManager.RoleExistsAsync(name);
            if (Manager == false)
            {
                await _roleManager.CreateAsync(new IdentityRole(name));
                return Ok($"{name} role Created Successfully");
            }

            
            return Ok(Manager);

        }

        // ----------------------------------------------- Users & Their Roles -------------------------------------
        
        [HttpPost]
        [Route("AddUserToRole")]
        public async Task<IActionResult> AddUserToRole(string email, string rolename)
        {
            //this is how we are going to find the email
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound("User not found with the provided email address.");
            }
            

            var roleExist = await _roleManager.RoleExistsAsync(rolename);
            if (!roleExist)
            {
                return NotFound("Role doesn't exist");
            }

            var userToRole = await _userManager.AddToRoleAsync(user, rolename);
            if (userToRole.Succeeded)
            {
                return Ok("User added to role successfully");
            }
            else
            {
                // Handle the case where adding the user to the role was not successful
                return BadRequest("Failed to add user to role. Error: " + string.Join(", ", userToRole.Errors.Select(e => e.Description)));
            }

        }

        [HttpPost]
        [Route("RemoveRole")]
        public async Task<IActionResult> removeFromRole(string userName,string roleName) {

            var username = await _userManager.FindByNameAsync(userName);
            if(username != null)
            {
                var removeRole = await _userManager.RemoveFromRoleAsync(username, roleName);
                _logger.LogInformation($"User successfully removed form the {roleName}");
                return Ok();
            }

            return NotFound("Username not found");

        }

        // ----------------------------------------------- Login Code ------------------------------------------

        [HttpPost]
        [Route("UserLogin")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            // Find the user by email
            var user = await _userManager.FindByEmailAsync(loginDto.UserName);

            if (user != null)
            {
                // Check if the provided plain text password matches the hashed password
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginDto.Password);

                if (passwordCheck)
                {
                    // Password is correct, you can proceed with your logic here
                    return Ok("User LoggedIn Successfully");
                }
                else
                {
                    // Password is incorrect, handle accordingly
                    return BadRequest("Invalid password");
                }
            }
            else
            {
                // User not found, handle accordingly
                return BadRequest("User not found");
            }
        }
        //-------------------------------------------------------Claims---------------------------------------------------------------

        [HttpPost]
        [Route("AddClaims")]
        public async Task<bool> AddClaimsAsync(string userId, List<Claim> claims)
        {
            var user = await _userManager.FindByIdAsync(userId);

            var result = await _userManager.AddClaimsAsync(user, claims);

            return result.Succeeded;
        }
        [HttpGet]
        [Route("GetClaims")]

        public async Task<List<Claim>> GetClaimsAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            

            var userClaims = await _userManager.GetClaimsAsync(user);

            return userClaims.ToList();
        }
    }

}
}
