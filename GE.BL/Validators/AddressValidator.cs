using FluentValidation;
using GE.BL.Entities;
using GE.BL.Messages;

namespace GE.BL.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.ZipCode).NotEmpty().WithMessage(ValidationMessages.zipCodeEmpty);
            RuleFor(x => x.Street).NotEmpty().WithMessage(ValidationMessages.streetEmpty);
            RuleFor(x => x.Neighborhood).NotEmpty().WithMessage(ValidationMessages.neighborhoodEmpty);
            RuleFor(x => x.State).NotEmpty().WithMessage(ValidationMessages.stateEmpty);
            RuleFor(x => x.City).NotEmpty().WithMessage(ValidationMessages.cityEmpty);
            RuleFor(x => x.HouseNumber).NotEmpty().WithMessage(ValidationMessages.houseNumberEmpty);
        }
    }
}
