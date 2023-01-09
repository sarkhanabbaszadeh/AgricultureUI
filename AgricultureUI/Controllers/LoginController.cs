using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
