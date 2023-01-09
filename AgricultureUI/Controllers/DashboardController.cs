using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
