using Core.Entities.Dtos;
using FluentValidation;

namespace Core.Business.ValidationRules.FluentValidation
{
    public class UserLoginValidator : AbstractValidator<UserForLoginDto>
    {
        public UserLoginValidator()
        {
            RuleFor(s => s.Email).NotEmpty().WithMessage("Email alanı boş geçilemez.");
            RuleFor(s => s.Password).NotEmpty().WithMessage("Parola alanı boş geçilemez.");
        }
    }
}