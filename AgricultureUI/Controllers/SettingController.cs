using AgricultureUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class SettingController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public SettingController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Mail = value.Email;
            userEditViewModel.Phone = value.PhoneNumber;
            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel useredit)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            if(useredit.Password==useredit.ConfirmPassword)
            {
                values.Email = useredit.Mail;
                values.PhoneNumber = useredit.Phone;
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, useredit.Password);
                var result = await _userManager.UpdateAsync(values);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
            }

            return View();
        }
    }
}
