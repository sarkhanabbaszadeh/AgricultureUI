using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Index()
        {
            var valus = _addressService.GetListAll();
            return View(valus);
        }

        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var value = _addressService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditAddress(Address address)
        {
            AddressValidator validationRules = new AddressValidator();
            ValidationResult result = validationRules.Validate(address);
            if (result.IsValid)
            {
                _addressService.Update(address);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
