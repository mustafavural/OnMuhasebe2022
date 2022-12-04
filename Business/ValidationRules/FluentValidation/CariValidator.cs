using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CariValidator : AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(s => s.Kod).NotEmpty();
            RuleFor(s => s.Unvan).NotEmpty();
            RuleFor(s => s.VergiDairesi).NotEmpty();
            RuleFor(s => s.VergiNo).NotEmpty();
            RuleFor(s => s.VergiNo).Length(10, 11);
        }
    }
}