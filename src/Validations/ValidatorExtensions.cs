using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;

namespace ShieldTech.Validations.Validations
{
    public static class ValidatorExtensions
    {
        public static void ApplyValidations(this IValidator validator, IList<ValidationResult> validations)
        {
            validations.Where(x => !x.IsValid).SelectMany(x => x.Errors).ToList().ForEach(x => validator.Add(x.PropertyName, x.ErrorMessage));
        }

        public static void ApplyValidations(this IValidator validator, ValidationResult validation)
        {
            if (!validation.IsValid)
                validation.Errors.ToList().ForEach(x => validator.Add(x.PropertyName, x.ErrorMessage));
        }
        
        public static void ApplyValidations(this IValidator validator, params ValidationResult[] validations)
        {
            validations.Where(x => !x.IsValid).SelectMany(x => x.Errors).ToList().ForEach(x => validator.Add(x.PropertyName, x.ErrorMessage));
        }

        public static IList<Error> CastToErrors(this IValidator validator)
        {
            return validator.Notifications.Select(x => new Error(x.Name, x.Value)).ToList();
        }
    }
}