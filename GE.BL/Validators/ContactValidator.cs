using FluentValidation;
using GE.BL.Entities;
using GE.BL.Messages;

namespace GE.BL.Validators
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(ValidationMessages.emailEmpty);
            RuleFor(x => x.Address).NotEmpty().WithMessage(ValidationMessages.addressNull);
        }
    }
}
