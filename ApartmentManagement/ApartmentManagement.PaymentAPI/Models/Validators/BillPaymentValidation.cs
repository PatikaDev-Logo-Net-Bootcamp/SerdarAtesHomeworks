using ApartmentManagement.PaymentAPI.DTOs;
using FluentValidation;

namespace ApartmentManagement.PaymentAPI.Models.Validators
{
    public class BillPaymentValidation : AbstractValidator<BillDto>
    {
        public BillPaymentValidation()
        {
            RuleFor(x=>x.Price).NotEmpty();
            RuleFor(x=>x.ValidMonth).NotEmpty();
            RuleFor(x=>x.ValidYear).NotEmpty();
            RuleFor(x=>x.CardNumber).NotEmpty();
            RuleFor(x=>x.Cvv).NotEmpty();
  
        }
    }
}
