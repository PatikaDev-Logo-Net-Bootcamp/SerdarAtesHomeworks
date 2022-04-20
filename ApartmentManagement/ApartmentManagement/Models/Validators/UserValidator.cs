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
            RuleFor(p => p.Password).NotEmpty()
             .WithMessage("Your password cannot be empty")
             .MinimumLength(6).WithMessage("Your password length must be at least 8.")
             .Matches("[A-Z]").WithMessage("Your password must contain at least one uppercase letter.")
             .Matches("[a-z]").WithMessage("Your password must contain at least one lowercase letter.")
             .Matches("[0-9]").WithMessage("Your password must contain at least one number.")
             .Matches(@"[\!\?\*\.]").WithMessage("Your password must contain at least one (!? *.).");





        }
    }
}
