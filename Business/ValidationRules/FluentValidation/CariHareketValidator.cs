using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CariHareketValidator : AbstractValidator<CariHareket>
    {
        public CariHareketValidator()
        {
            RuleFor(s => s.CariId).NotEmpty();
            RuleFor(s => s.Tutar).NotEmpty();
            RuleFor(s => s.Tarih).NotEmpty();
            RuleFor(s => s.Aciklama).NotEmpty();
        }
    }
}
