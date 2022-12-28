using System.ComponentModel.DataAnnotations;

namespace AgricultureUI.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Başlıq")]
        [Required(ErrorMessage ="Başlıq boş buraxıla bilməz!")]
        public string Title { get; set; }

        [Display(Name = "Şəkil")]
        [Required(ErrorMessage = "Şəkil boş buraxıla bilməz!")]
        public string Image { get; set; }

        [Display(Name = "Açıqlama")]
        [Required(ErrorMessage = "Açıqlama boş buraxıla bilməz!")]
        public string Description { get; set; }
    }
}
