using FluentValidation;
using TaskTracker.Models.Requests;
using TaskTracker.Validators.Interfaces;

namespace TaskTracker.Validators
{
  public class CreateProjectRequestValidator : AbstractValidator<CreateProjectRequest>, ICreateProjectRequestValidator
  {
    public CreateProjectRequestValidator()
    {
      RuleFor(x => x).NotNull().WithMessage("Can't be null");

      RuleFor(x => x.Name)
        .NotNull()
        .NotEmpty()
        .WithMessage("Name can't be null or empty");
    }
  }
}
