using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class KasaHareketValidator : AbstractValidator<KasaHareket>
    {
        public KasaHareketValidator()
        {
            RuleFor(s => s.EvrakNo).NotEmpty();
            RuleFor(s => s.EvrakNo).Length(14);
            RuleFor(s => s.EvrakNo).Must(StartWithK).WithMessage("Evrak No 'K' harfi ile başlamalıdır.");
            RuleFor(s => s.KasaId).NotEmpty();
            RuleFor(s => s.GirenCikanMiktar).NotEmpty();
            RuleFor(s => s.GirenCikanMiktar).GreaterThan(0).WithMessage("Miktar 0(sıfır) veya negatif olamaz.");
        }

        private bool StartWithK(string arg)
        {
            return arg.StartsWith('K');
        }
    }
}