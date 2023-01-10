using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.ViewComponents
{
    public class _DashboardChartPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = 53;
            ViewBag.v2 = 45;
            ViewBag.v3 = 39;
            ViewBag.v4 = 24;
            ViewBag.v5 = 14;
            return View();
        }
    }
}
