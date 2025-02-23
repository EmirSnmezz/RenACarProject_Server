﻿using FluentValidation;

namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            ValidationContext<object> validationContext = new ValidationContext<object>(entity);
            var result = validator.Validate(validationContext);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
        }
    }
}
