using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracking.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class IssueController : Controller
{
    [Authorize]
    [HttpGet("[action]")]
    public IActionResult AllIssue()
    {
        return Ok();
    }
    [Authorize]
    [HttpGet("[action]")]
    public IActionResult GetIssue()
    {
        return Ok();
    }
    [Authorize]
    [HttpGet("[action]")]
    public IActionResult GetIssueDetailById()
    {
        return Ok();
    }
    [Authorize]
    [HttpGet("[action]")]
    public IActionResult AddIssue()
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
    public IActionResult ChangeStatus()
    {
        return Ok();
    }
    [Authorize]
    [HttpGet("[action]")]
    public IActionResult AssigneOtherUser()
    {
        return Ok();
    }
}
