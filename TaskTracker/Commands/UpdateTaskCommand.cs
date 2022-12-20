using FluentValidation;
using TaskTracker.Commands.Interfaces;
using TaskTracker.Models.DbModels;
using TaskTracker.Repositories.Interfaces;
using TaskTracker.Validators.Interfaces;

namespace TaskTracker.Commands
{
  public class UpdateTaskCommand : IUpdateTaskCommand
  {
    private readonly ITaskRepository _repository;
    private readonly ITaskValidator _validator;

    public UpdateTaskCommand(ITaskRepository repository, ITaskValidator validator)
    {
      _repository = repository;
      _validator = validator;
    }
    public async Task ExecuteAsync(DbTask task)
    {
      try
      {
        _validator.ValidateAndThrow(task);

        await _repository.UpdateAsync(task);
      }
      catch { }
    }
  }
}
