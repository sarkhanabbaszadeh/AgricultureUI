using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlıq boş buraxıla bilməz!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıqlama boş buraxıla bilməz!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Şəkil ünvanı boş buraxıla bilməz!");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Zəhmət olmasa 20 hərfdən çox söz daxil etməyin!");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Zəhmət olmasa 8 hərfdən az söz daxil etməyin!");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Zəhmət olmasa 50 hərfdən çox söz daxil etməyin!");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Zəhmət olmasa 20 hərfdən az söz daxil etməyin!");
        }
    }
}
