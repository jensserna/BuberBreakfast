using BuberBreakfast.Contracts.Breakfast;
using FluentValidation;

namespace BuberBreakfast.Validations;

public class CreateBreakfastRequestValidator : AbstractValidator<CreateBreakfastRequest>
{
    public CreateBreakfastRequestValidator()
    {
        RuleFor(x => x.Name).Length(3, 10);
    }
}