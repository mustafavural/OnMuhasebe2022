using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class KasaValidator : AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(s => s.Ad).NotEmpty();
            RuleFor(s => s.Ad).Length(5, 50);
        }
    }
}
