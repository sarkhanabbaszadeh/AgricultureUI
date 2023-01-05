using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıqlama 1 boş buraxıla bilməz!");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıqlama 2 boş buraxıla bilməz!");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Açıqlama 3 boş buraxıla bilməz!");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Açıqlama 4 boş buraxıla bilməz!");
            RuleFor(x => x.Mapinfo).NotEmpty().WithMessage("Xəritə boş buraxıla bilməz!");
            RuleFor(x => x.Description1).MaximumLength(25).WithMessage("Zəhmət olmasa açıqlamanı azaldın!(max 25)");
            RuleFor(x => x.Description2).MaximumLength(25).WithMessage("Zəhmət olmasa açıqlamanı azaldın!(max 25)");
            RuleFor(x => x.Description3).MaximumLength(25).WithMessage("Zəhmət olmasa açıqlamanı azaldın!(max 25)");
            RuleFor(x => x.Description4).MaximumLength(25).WithMessage("Zəhmət olmasa açıqlamanı azaldın!(max 25)");
        }
    }
}
