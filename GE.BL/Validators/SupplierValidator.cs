using FluentValidation;
using GE.BL.Entities;
using GE.BL.Messages;

namespace GE.BL.Validators
{
    public class SupplierValidator : AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(ValidationMessages.supplierNameEmpty);
            RuleFor(x => x.Cnpj).NotEmpty().WithMessage(ValidationMessages.cnpjInvalid);
            RuleFor(x => x.Cnpj).MaximumLength(14).WithMessage(ValidationMessages.cnpjInvalidLength);
        }
    }
}
