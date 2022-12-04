using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BankaHareketValidator : AbstractValidator<BankaHareket>
    {
        public BankaHareketValidator()
        {
            RuleFor(s => s.EvrakNo).NotNull();
            RuleFor(s => s.GirenCikanMiktar).NotNull();
            RuleFor(s => s.BankaHesapId).NotNull();
            RuleFor(s => s.Tarih).NotNull();
            RuleFor(s => s.EvrakNo).Length(14);
            RuleFor(s => s.GirenCikanMiktar).NotEqual(0);
            RuleFor(s => s.Tarih).GreaterThanOrEqualTo(DateTime.Today);
        }
    }
}
