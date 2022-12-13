using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CekSenetBorcValidator : AbstractValidator<CekSenetBorc>
    {
        public CekSenetBorcValidator()
        {
            RuleFor(s => s.No).NotEmpty().WithMessage("EvrakNo mutlaka girilmelidir.");
            RuleFor(s => s.BordroTediyeId).NotEmpty().WithMessage("Evrak alışında bordro bilgisi gereklidir.");
            RuleFor(s => s.Vade).NotEmpty().WithMessage("Vade bilgisi gereklidir.");
            RuleFor(s => s.Vade).LessThanOrEqualTo(DateTime.Today).WithMessage("Vadesi geçmiş evrak girişi yapılamaz.");
            RuleFor(s => s.Tutar).NotEmpty().WithMessage("Tutar bilgisi gereklidir.");
            RuleFor(s => s.Tutar).GreaterThan(0).WithMessage("Tutar bilgisi 0(sıfır)dan büyük olmalıdır.");
        }
    }
}
