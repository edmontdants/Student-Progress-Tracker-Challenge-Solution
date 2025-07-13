using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StudentProgress.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var token = Guid.NewGuid().ToString(); // fake token
            var role = request.Username == "teacher" ? "Teacher" : "Admin";

            return Ok(new { token, role, username = request.Username });
        }

        [Authorize]
        [HttpGet("profile")]
        public IActionResult Profile()
        {
            return Ok(new { username = "mockUser", roles = new[] { "Teacher" } });
        }

        [Authorize(Roles = "Teacher")]
        [HttpGet("/api/users/{id}/students")]
        public IActionResult GetStudentsForTeacher(Guid id)
        {
            // Normally you'd filter students assigned to this teacher
            return Ok(new { message = $"Mock students for teacher {id}" });
        }
    }
}

public record LoginRequest(string Username, string Password);

