using ApartmentManagement.Business.DTOs;
using FluentValidation;

namespace ApartmentManagement.Models.Validators
{
    public class UserValidator : AbstractValidator<UserAddDto>
    {
        public UserValidator()
        {
            RuleFor(x=>x.TcNo).NotEmpty().MaximumLength(11).MinimumLength(11);
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.CarPlateNumber).NotEmpty();
            RuleFor(x=>x.Email).EmailAddress().NotEmpty();
            




        }
    }
}
