namespace bookannotation_api.Models.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] UserLogin userLogin)
        {
            return NotFound("User not found");
        }

        [HttpGet(Name = "User")]
        public User Get()
        {
            return new User();
        }
    }
}