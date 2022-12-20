using Core.Entities.Dtos;
using FluentValidation;
using System.Linq;

namespace Core.Business.ValidationRules.FluentValidation
{
    public class UserRegisterValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserRegisterValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("Ad Boş Geçilemez.");
            RuleFor(s => s.LastName).NotEmpty().WithMessage("Soyad Boş Geçilemez.");
            RuleFor(s => s.Email).NotEmpty().WithMessage("Email Adresi Boş Geçilemez.");
            RuleFor(s => s.Email).EmailAddress().WithMessage("Email adresi geçersiz.");
            RuleFor(s => s.Password).MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır.");
            RuleFor(s => s.Password).MaximumLength(8).WithMessage("Şifre en çok 8 karakter olmalıdır.");
            RuleFor(s => s.Password).Must(ContainsAtLeastOneUpperCase).WithMessage("Parola en az bir büyük harf içermelidir.");
            RuleFor(s => s.Password).Must(ContainsAtLeastOneLowerCase).WithMessage("Parola en az bir küçük harf içermelidir.");
            RuleFor(s => s.Password).Must(ContainsAtLeastOneNumber).WithMessage("Parola en az bir rakam içermelidir.");
            RuleFor(s => s.Password).Must(ContainsAtLeastOneSpecialChar).WithMessage("Parola en az bir özel karakter içermelidir.");
            RuleFor(s => s.Password).Must(ContainsAtLeastOneSpecialChar).WithMessage("Parola en az bir özel karakter içermelidir.");
        }

        private bool ContainsAtLeastOneUpperCase(string password)
        {
            foreach (var c in password)
            {
                if (64 < c && c < 91)
                    return true;
            }
            return false;
        }

        private bool ContainsAtLeastOneLowerCase(string password)
        {
            foreach (var c in password)
            {
                if (96 < c && c < 123)
                    return true;
            }
            return false;
        }

        private bool ContainsAtLeastOneNumber(string password)
        {
            foreach (var c in password)
            {
                if (47 < c && c < 58)
                    return true;
            }
            return false;
        }

        private bool ContainsAtLeastOneSpecialChar(string password)
        {
            foreach (var c in password)
            {
                if (c < 48 || (57 < c && c < 65) || (90 < c && c < 97) || 122 < c)
                    return true;
            }
            return false;
        }
    }
}