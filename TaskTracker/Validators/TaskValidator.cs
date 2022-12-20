using FluentValidation;
using TaskTracker.Models.DbModels;
using TaskTracker.Validators.Interfaces;

namespace TaskTracker.Validators
{
  public class TaskValidator : AbstractValidator<DbTask>, ITaskValidator
  {
    public TaskValidator()
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
