using FluentValidation;
using System;

namespace DRAGONSTavern.Domain.Helpers.Validator
{
    public class Validator<T> where T : class
    {
        private readonly IValidator<T> _validator;

        public Validator(IValidator<T> validator) => _validator = validator;

        public void Validate(T obj)
        {
            var validatorResult = _validator.Validate(obj);

            if (!validatorResult.IsValid)
            {
                var errorMessage = string.Empty;

                foreach (var error in validatorResult.Errors)
                {
                    errorMessage += $"{error.ErrorMessage}\n";
                }

                throw new Exception(errorMessage);
            }
        }
    }
}
