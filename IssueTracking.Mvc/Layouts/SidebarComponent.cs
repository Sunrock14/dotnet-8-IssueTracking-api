using Microsoft.AspNetCore.Mvc;

namespace IssueTracking.Mvc.Layouts
{
    [ViewComponent(Name = "Sidebar")]
    public class SidebarComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }

}
