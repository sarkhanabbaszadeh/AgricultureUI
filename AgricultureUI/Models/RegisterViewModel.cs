using System.ComponentModel.DataAnnotations;

namespace AgricultureUI.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Zəhmət olmasa istifadəçi adı daxil edin!")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Zəhmət olmasa e-poçta adresinizi daxil edin!")]
        public string email { get; set; }

        [Required(ErrorMessage = "Zəhmət olmasa şifrə daxil edin!")]
        public string password { get; set; }

        [Required(ErrorMessage = "Zəhmət olmasa şifrəni təkrar daxil edin!")]
        [Compare("password",ErrorMessage ="Şifrələr eyni deyil, Zəhmət olmasa təkrar yazın!")]
        public string passwordConfirm { get; set; }

    }
}
