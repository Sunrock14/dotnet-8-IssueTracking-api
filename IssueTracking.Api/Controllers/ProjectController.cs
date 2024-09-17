using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public ProjectController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult AllUsers()
        {
            return Ok();
        }
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult AddUser()
        {
            return Ok();
        }
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult UpdateUser()
        {
            return Ok();
        }
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult DeleteUser()
        {
            return Ok();
        }
    }
}
