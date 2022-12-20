using FluentValidation;
using TaskTracker.Models.DbModels;

namespace TaskTracker.Validators.Interfaces
{
  public interface ITaskValidator : IValidator<DbTask>
  {
  }
}
