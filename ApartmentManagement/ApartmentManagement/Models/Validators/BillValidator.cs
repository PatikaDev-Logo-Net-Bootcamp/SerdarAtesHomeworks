using ApartmentManagement.Domain.Entities;
using FluentValidation;

namespace ApartmentManagement.Models.Validators
{
    public class BillValidator : AbstractValidator<Bill>
    {
        public BillValidator()
        {
            RuleFor(x=>x.Price).NotEmpty();
            RuleFor(x=>x.BillDate).NotEmpty();
            RuleFor(x=>x.BillTypeId).NotEmpty();
            RuleFor(x=>x.FlatId).NotEmpty();
        }
    }
}
