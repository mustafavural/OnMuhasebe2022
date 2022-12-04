using Business.Constants;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class FaturaValidator : AbstractValidator<Fatura>
    {
        public FaturaValidator()
        {
            RuleFor(s => s.No).NotEmpty();
            RuleFor(s => s.No).Length(14);
            RuleFor(s => s.No).Must(StartWithF).WithMessage(Messages.FaturaMessages.FHarfliIleBaslamalidir);
            RuleFor(s => s.Tarih).NotEmpty();
            RuleFor(s => s.KayitTarihi).NotEmpty();
            RuleFor(s => s.Tur).NotEmpty();
            RuleFor(s => s.Aciklama).MaximumLength(250);
        }

        private bool StartWithF(string arg)
        {
            return arg.StartsWith('F');
        }
    }
}