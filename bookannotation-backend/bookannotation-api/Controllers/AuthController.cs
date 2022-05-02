using bookannotation_api.Models;
using bookannotation_api.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bookannotation_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register([FromBody] UserRegisterDto user) 
        {
            if (user == null) 
            {
                throw new Exception($"User dto is null");
            }
            
            var createdUser = await _userService.CreateUser(user);
            
            return createdUser;
        }

    }
}
