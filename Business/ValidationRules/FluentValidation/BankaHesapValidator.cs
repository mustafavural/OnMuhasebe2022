using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BankaHesapValidator : AbstractValidator<BankaHesap>
    {
        public BankaHesapValidator()
        {
            RuleFor(s => s.HesapNo).NotNull();
            RuleFor(s => s.BankaAd).NotNull();
            RuleFor(s => s.BankaSubeAd).NotNull();
            RuleFor(s => s.HesapNo).Length(30);
            RuleFor(s => s.BankaAd).Length(10, 50);
            RuleFor(s => s.BankaSubeAd).Length(10, 50);
        }
    }
}