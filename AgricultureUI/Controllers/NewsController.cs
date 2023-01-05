using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        public IActionResult Index()
        {
            var values = _newsService.GetListAll();
            return View(values);
        }

        [HttpGet] 
        public IActionResult AddNews()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNews(News n)
        {
            n.Date= DateTime.Parse(DateTime.Now.ToShortDateString());
            n.Status = false;
            _newsService.Insert(n);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteNews(int id)
        {
            _newsService.Delete(_newsService.GetById(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditNews(int id)
        {
            var values=_newsService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditNews(News n)
        {
            _newsService.Update(n);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToTrue(int id)
        {
            _newsService.NewsStatusToTrue(id);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToFalse(int id)
        {
            _newsService.NewsStatusToFalse(id);
            return RedirectToAction("Index");
        }

    }
}
