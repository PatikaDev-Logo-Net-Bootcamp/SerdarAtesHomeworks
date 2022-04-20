using ApartmentManagement.Business.DTOs;
using FluentValidation;

namespace ApartmentManagement.Models.Validators
{
    public class PaymentValidator : AbstractValidator<PaymentDto>
    {
        public PaymentValidator()
        {
            RuleFor(x=>x.ValidYear).NotEmpty().MaximumLength(4).MinimumLength(4);
            RuleFor(x=>x.ValidMonth).NotEmpty().MaximumLength(2).MinimumLength(1);
            RuleFor(x=>x.CardNumber).NotEmpty().MaximumLength(16).MinimumLength(16);
            RuleFor(x=>x.Cvv).NotEmpty().MaximumLength(3).MinimumLength(3);
   
        }
    }
}
