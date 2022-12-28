using System.ComponentModel.DataAnnotations;

namespace BuberBreakfast.Contracts.DataAnnotations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
public class FutureAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        return value switch
        {
            DateTime date when date > DateTime.Now => ValidationResult.Success,
            _ => new ValidationResult("The date must be in the future.")
        };
    }
}