using DRAGONSTavern.Domain.ValueObjects;
using FluentValidation;

namespace DRAGONSTavern.Domain.Validators
{
    public class SharedValidator : AbstractValidator<Shared>
    {
        public SharedValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("The Id cannot be null.")
                .NotEmpty().WithMessage("The Id cannot be empty.")
                .MaximumLength(40).WithMessage("The maximum length of Id is 10.");
        }
    }
}
