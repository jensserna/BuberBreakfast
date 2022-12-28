using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Services.Breakfasts;
using BuberBreakfast.Validations;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddScoped<IBreakfastService, BreakfastService>();
    builder.Services.AddScoped<IValidator<CreateBreakfastRequest>, CreateBreakfastRequestValidator>();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}