using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var valus = _contactService.GetListAll();
            return View(valus);
        }

        public IActionResult DeleteContact(int id)
        {
            var value=_contactService.GetById(id);
            _contactService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var value = _contactService.GetById(id);
            return View(value);
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(Contact contact)
        {
            contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _contactService.Insert(contact);
            return RedirectToAction("Index", "Home");
        }
    }
}
