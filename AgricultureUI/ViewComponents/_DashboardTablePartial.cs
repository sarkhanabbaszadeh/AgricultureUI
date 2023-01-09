using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.ViewComponents
{
    public class _DashboardTablePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
