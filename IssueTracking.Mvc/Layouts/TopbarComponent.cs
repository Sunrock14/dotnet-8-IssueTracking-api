using Microsoft.AspNetCore.Mvc;

namespace IssueTracking.Mvc.Layouts
{
    [ViewComponent(Name = "Topbar")]
    public class Topbar : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }

}
