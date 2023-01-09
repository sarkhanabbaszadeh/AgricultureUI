using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.ViewComponents
{
    public class _DashboardOverViewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AgricultureContext agricultureContext = new AgricultureContext();
            ViewBag.teamCount = agricultureContext.Teams.Count();
            ViewBag.servisCount=agricultureContext.Services.Count();
            ViewBag.messageCount=agricultureContext.Contacts.Count();
            ViewBag.currentMonthMessage = agricultureContext.Contacts.Where(x=>x.Date.Month==DateTime.Now.Month).Count();

            ViewBag.newsTrue = agricultureContext.Newses.Where(x=>x.Status==true).Count();
            ViewBag.newsFalse = agricultureContext.Newses.Where(x => x.Status == false).Count();

            ViewBag.productMarketing = agricultureContext.Teams.Where(x => x.Title == "Satış Təmsilcisi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.productSmm = agricultureContext.Teams.Where(x => x.Title == "SMM Manager").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.productDesign = agricultureContext.Teams.Where(x => x.Title == "Dizayner").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.productProgramming = agricultureContext.Teams.Where(x => x.Title == "Proqramçı").Select(y => y.PersonName).FirstOrDefault();
            return View();
        }
    }
}
