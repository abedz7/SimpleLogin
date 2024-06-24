using LoginDemo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DatabaseService _databaseService;

        public UsersController()
        {
            _databaseService = new DatabaseService();
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = _databaseService.AuthenticateUser(request.Email, request.Password);
            if (user != null)
            {
                return Ok(new { message = "Login successful", user });
            }
            else
            {
                return Unauthorized(new { message = "Invalid email or password" });
            }
        }

    }
}
