using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class MusteriEvrakValidator : AbstractValidator<MusteriEvrak>
    {
        public MusteriEvrakValidator()
        {
            RuleFor(s => s.AlisTarihi).NotEmpty().WithMessage("Alış tarihi girilmelidir.");
            RuleFor(s => s.AlisTarihi).LessThanOrEqualTo(DateTime.Today).WithMessage("Evrakın alış tarihi ileri bir tarih olamaz.");
            RuleFor(s => s.AsilBorclu).NotEmpty().WithMessage("Asıl borçlu bilgisi gereklidir.");
        }
    }
}
