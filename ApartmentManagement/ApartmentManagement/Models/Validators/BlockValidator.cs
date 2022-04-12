using ApartmentManagement.Domain.Entities;
using FluentValidation;

namespace ApartmentManagement.Models.Validators
{
    public class BlockValidator : AbstractValidator<Block>
    {

        public BlockValidator()
        {
            RuleFor(x=>x.BlockName).NotNull().WithMessage("Hata");
        }
    }
}
