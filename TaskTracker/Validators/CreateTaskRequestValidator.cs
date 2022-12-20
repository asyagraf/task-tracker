using FluentValidation;
using TaskTracker.Models.Requests;
using TaskTracker.Validators.Interfaces;

namespace TaskTracker.Validators
{
  public class CreateTaskRequestValidator : AbstractValidator<CreateTaskRequest>, ICreateTaskRequestValidator
  {
    public CreateTaskRequestValidator()
    {
      RuleFor(x => x).NotNull().WithMessage("Can't be null");

      RuleFor(x => x.Name)
        .NotNull()
        .NotEmpty()
        .WithMessage("Name can't be null or empty");

      RuleFor(x => x.Description)
        .NotNull()
        .NotEmpty()
        .WithMessage("Name can't be null or empty");
    }
  }
}
