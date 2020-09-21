using DRAGONSTavern.Domain.Entities;
using FluentValidation;

namespace DRAGONSTavern.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email)
                .NotNull().WithMessage("The Email cannot be null.")
                .NotEmpty().WithMessage("The Email cannot be empty.")
                .MaximumLength(50).WithMessage("The maximum length of Email is 50.");

            RuleFor(x => x.Password)
                .NotNull().WithMessage("The Password cannot be null.")
                .NotEmpty().WithMessage("The Password cannot be empty.")
                .MaximumLength(200).WithMessage("The maximum length of Password is 200.");
        }
    }
}
