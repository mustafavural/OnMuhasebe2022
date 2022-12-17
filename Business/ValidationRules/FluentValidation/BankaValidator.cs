using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BankaValidator : AbstractValidator<Banka>
    {
        public BankaValidator()
        {
            RuleFor(s => s.BankaAd).NotNull();
            RuleFor(s => s.BankaAd).MinimumLength(5);
            RuleFor(s => s.BankaSubeAd).NotNull();
            RuleFor(s => s.BankaSubeAd).MinimumLength(5);
            RuleFor(s => s.HesapNo).NotNull();
            RuleFor(s => s.HesapNo).MaximumLength(10);
            RuleFor(s => s.IBAN).NotNull();
            RuleFor(s => s.IBAN).Length(25, 30);
        }
    }
}