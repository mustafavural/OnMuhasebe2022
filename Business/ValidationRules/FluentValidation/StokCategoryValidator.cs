using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StokCategoryValidator : AbstractValidator<StokCategory>
    {
        public StokCategoryValidator()
        {
            RuleFor(s => s.Ad).NotEmpty();
            RuleFor(s => s.Ad).MinimumLength(3);
        }
    }
}
