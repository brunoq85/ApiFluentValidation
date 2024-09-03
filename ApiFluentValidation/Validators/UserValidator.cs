using ApiFluentValidation.Entities;
using FluentValidation;

namespace ApiFluentValidation.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator() 
        {
            RuleFor(u => u.FirstName)
               .NotEmpty().WithMessage("First name is required.")
               .Length(2, 50).WithMessage("First name must be between 2 and 50 characters.");

            RuleFor(u => u.LastName)
            .NotEmpty().WithMessage("Last name is required.")
            .Length(2, 50).WithMessage("Last name must be between 2 and 50 characters.");

            RuleFor(u => u.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("A valid email is required.");

            RuleFor(u => u.DateOfBirth)
                .NotEmpty().WithMessage("Date of birth is required.")
                .LessThan(DateTime.Now).WithMessage("Date of birth must be in the past.");

            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(8).WithMessage("Password must be at least 8 characters long.")
                .Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
                .Matches("[a-z]").WithMessage("Password must contain at least one lowercase letter.")
                .Matches("[0-9]").WithMessage("Password must contain at least one number.")
                .Matches("[^a-zA-Z0-9]").WithMessage("Password must contain at least one special character.");
        }
    }
}
