using ApartmentManagement.Business.DTOs;
using ApartmentManagement.Domain;
using FluentValidation;

namespace ApartmentManagement.Models.Validators
{
    public class FlatValidator : AbstractValidator<FlatAddDto>
    {
        public FlatValidator()
        {
            RuleFor(x => x.Type).NotEmpty();
            RuleFor(x => x.OwnerId).NotEmpty();
            RuleFor(x => x.IsEmpty).NotEmpty();
            RuleFor(x => x.IsOwner).NotEmpty();
            RuleFor(x => x.BlockId).NotEmpty();
            RuleFor(x => x.FlatNo).NotEmpty();
            RuleFor(x => x.Floor).NotEmpty();
        }
    }
}
