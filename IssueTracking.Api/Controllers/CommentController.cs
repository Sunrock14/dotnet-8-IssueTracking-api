using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracking.Api.Controllers
{
    public class CommentController : ControllerBase
    {
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult AddComment()
        {
            return Ok();
        }
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult UpdateComment()
        {
            return Ok();
        }
    }
}
