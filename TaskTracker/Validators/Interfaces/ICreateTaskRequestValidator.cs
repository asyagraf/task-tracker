using FluentValidation;
using TaskTracker.Models.Requests;

namespace TaskTracker.Validators.Interfaces
{
  public interface ICreateTaskRequestValidator : IValidator<CreateTaskRequest>
  {
  }
}
