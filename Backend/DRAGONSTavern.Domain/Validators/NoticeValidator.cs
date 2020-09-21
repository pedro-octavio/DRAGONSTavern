using DRAGONSTavern.Domain.Entities;
using FluentValidation;

namespace DRAGONSTavern.Domain.Validators
{
    public class NoticeValidator : AbstractValidator<Notice>
    {
        public NoticeValidator()
        {
            RuleFor(x => x.Title)
                .NotNull().WithMessage("The Title cannot be null.")
                .NotEmpty().WithMessage("The Title cannot be empty.")
                .MaximumLength(40).WithMessage("The maximum length of Title is 40.");

            RuleFor(x => x.Body)
                .NotNull().WithMessage("The Body cannot be null.")
                .NotEmpty().WithMessage("The Body cannot be empty.")
                .MaximumLength(40).WithMessage("The maximum length of Body is 35.000.");

            RuleFor(x => x.CreateDate)
                .NotNull().WithMessage("The CreateDate cannot be null.");

            RuleFor(x => x.BannerImageUrl)
                .MaximumLength(50).WithMessage("The maximum length of BannerImageUrl is 50.");
        }
    }
}
