using System.ComponentModel.DataAnnotations;

namespace AgricultureUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Zəhmət olmasa istifadəçi adınızı daxil edin!")]
        public string username { get; set; }

        [Required(ErrorMessage = "Zəhmət olmasa şifrənizi daxil edin!")]
        public string password { get; set; }
    }
}
