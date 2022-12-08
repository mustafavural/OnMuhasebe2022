using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StokHareketValidator : AbstractValidator<StokHareket>
    {
        public StokHareketValidator()
        {
            RuleFor(s => s.Miktar).NotEmpty().WithMessage("Miktar boş geçilemez!");
            RuleFor(s => s.Birim).NotEmpty();
            RuleFor(s => s.Fiyat).NotEmpty();
            RuleFor(s => s.Fiyat).GreaterThanOrEqualTo(0).WithMessage("Fiyat negatif olamaz!");
            RuleFor(s => s.BrutTutar).NotEmpty();
            RuleFor(s => s.Kdv).NotEmpty();
            RuleFor(s => s.Kdv).GreaterThanOrEqualTo(0).WithMessage("Kdv negatif olamaz!");
            RuleFor(s => s.NetTutar).NotEmpty();
            RuleFor(s => s.Tarih).NotEmpty();
            RuleFor(s => s.Aciklama).NotEmpty();
        }
    }
}