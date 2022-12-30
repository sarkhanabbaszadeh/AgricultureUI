using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Əməkdaş adı boş buraxıla bilməz!");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Vəzifə boş buraxıla bilməz!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Şəkil yolu boş buraxıla bilməz!");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Zəhmət olmasa 50 hərf limiti aşmayın!");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Zəhmət olmasa ən azı 5 həfdən ibarət söz daxil edin!");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Zəhmət olmasa 50 hərf limiti aşmayın!");
            RuleFor(X => X.Title).MinimumLength(3).WithMessage("Zəhmət olmasa ən azı 3 həfdən ibarət söz daxil edin!");
        }
    }
}
