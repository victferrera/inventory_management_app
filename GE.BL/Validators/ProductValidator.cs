using FluentValidation;
using GE.BL.Entities;
using GE.BL.Messages;

namespace GE.BL.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(ValidationMessages.productNameEmpty);
        }
    }
}
