using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CekSenetBordroValidator : AbstractValidator<CekSenetBordro>
    {
        public CekSenetBordroValidator()
        {
            RuleFor(s => s.No).NotEmpty().WithMessage("Bordro no boş geçilemez.");
            RuleFor(s => s.CariId).NotEmpty().WithMessage("Cari bilgisi mutlaka girilmelidir.");
            RuleFor(s => s.Tarih).Equal(DateTime.Today).WithMessage("Girilen tarih bugünden önce veya sonra olamaz");
            RuleFor(s => s.Aciklama).NotEmpty().WithMessage("Bir açıklama giriniz.");
            RuleFor(s => s.Aciklama).Length(10, 250).WithMessage("Açıklama 10 ile 250 karakter arasında olmalı");
        }
    }
}