using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StokValidator : AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(s => s.Kod).NotEmpty();
            RuleFor(s => s.Kod).Length(0, 10);
            RuleFor(s => s.Ad).NotEmpty();
            RuleFor(s => s.Ad).Length(0, 255);
            RuleFor(s => s.Barkod).NotEmpty();
            RuleFor(s => s.Barkod).Length(0, 15);
            RuleFor(s => s.Birim).NotEmpty();
            RuleFor(s => s.Birim).Length(0, 50);
        }
    }
}