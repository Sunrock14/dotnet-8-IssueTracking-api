using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracking.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
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
    [Authorize]
    [HttpGet("[action]")]
    public IActionResult ChangeRole()
    {
        return Ok();
    }
}
