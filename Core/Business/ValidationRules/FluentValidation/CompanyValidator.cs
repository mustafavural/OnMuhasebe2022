using Core.Entities.Concrete;
using FluentValidation;

namespace Core.Business.ValidationRules.FluentValidation
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(s => s.Status).NotEmpty().WithMessage("Durum alanı boş geçilemez.");
            RuleFor(s => s.Year).NotEmpty().WithMessage("Yıl alanı boş geçilemez.");
            RuleFor(s => s.Detail).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
        }
    }
}