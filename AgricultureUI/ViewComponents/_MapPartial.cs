using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.ViewComponents
{
    public class _MapPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AgricultureContext agricultureContext = new AgricultureContext();
            var values=agricultureContext.Addresses.Select(x=>x.Mapinfo).FirstOrDefault();
            ViewBag.m=values;
            return View();
        }
    }
}
