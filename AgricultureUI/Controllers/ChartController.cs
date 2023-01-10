using AgricultureUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductChart()
        {
            List<ProductClass> productClasses= new List<ProductClass>();

            productClasses.Add(new ProductClass()
            {
                productname = "Tibbi Web sayt",
                productvalue = 2
            }); 

            productClasses.Add(new ProductClass()
            {
                productname = "Tibbi Desktop app",
                productvalue = 4
            });     
            
            productClasses.Add(new ProductClass()
            {
                productname = "Kargo Web sayt",
                productvalue = 5
            });       
            
            productClasses.Add(new ProductClass()
            {
                productname = "Kargo Desktop app",
                productvalue = 1
            });

            return Json(new { jsonlist = productClasses });
        }
    }
}
