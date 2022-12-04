using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class AdresValidator : AbstractValidator<Adres>
    {
        public AdresValidator()
        {
            RuleFor(s => s.IlceId).NotEmpty();
            RuleFor(s => s.Telefon).Must(TelefonGecerliMi).When(s => s.Telefon != null).WithMessage("Telefon numarası değil.");
            RuleFor(s => s.Telefon2).Must(TelefonGecerliMi).When(s => s.Telefon2 != null).WithMessage("Telefon numarası değil.");
            RuleFor(s => s.Fax).Must(TelefonGecerliMi).When(s => s.Fax != null).WithMessage("Fax numarası değil.");
            RuleFor(s => s.Eposta).EmailAddress().When(s => s.Eposta != null);
        }

        private bool TelefonGecerliMi(string? arg)
        {
            return arg?.Length == 14 && arg.StartsWith("00");
        }
    }
}