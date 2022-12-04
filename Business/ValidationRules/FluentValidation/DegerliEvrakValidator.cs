using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class DegerliEvrakValidator : AbstractValidator<DegerliEvrak>
    {
        public DegerliEvrakValidator()
        {
            RuleFor(s => s.Kod).NotEmpty().WithMessage("Evrak kodu girilmelidir.");
            RuleFor(s => s.Vade).NotEmpty().WithMessage("Vade tarihi boş geçilemez.");
            RuleFor(s => s.Tutar).NotEmpty().WithMessage("Evrakın değeri girilmelidir.");
            RuleFor(s => s.Aciklama).NotEmpty().WithMessage("Bir açıklama giriniz.");
            RuleFor(s => s.Vade).GreaterThan(DateTime.Today).WithMessage("Girilen vade tarihi bugünden önce olamaz");
            RuleFor(s => s.Tutar).GreaterThan(0).WithMessage("Tutar sıfır(0)'dan büyük olmalıdır.");
            RuleFor(s => s.Aciklama).Length(10, 250).WithMessage("Açıklama 10 ile 250 karakter arasında olmalı");
        }
    }
    public class DegerliEvrakCikarkenValidator : AbstractValidator<DegerliEvrak>
    {
        public DegerliEvrakCikarkenValidator()
        {
            RuleFor(s => s.CikisTarihi).NotEmpty().WithMessage("Çıkış tarihi olmadan çıkış yapılamaz");
            RuleFor(s => s.CikisTarihi).LessThanOrEqualTo(DateTime.Today).WithMessage("Çıkış tarihi ileri tarihli olamaz.");
        }
    }
}