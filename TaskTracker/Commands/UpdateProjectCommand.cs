using FluentValidation;
using TaskTracker.Commands.Interfaces;
using TaskTracker.Models.DbModels;
using TaskTracker.Repositories.Interfaces;
using TaskTracker.Validators.Interfaces;

namespace TaskTracker.Commands
{
  public class UpdateProjectCommand : IUpdateProjectCommand
  {
    private readonly IProjectRepository _repository;
    private readonly IProjectValidator _validator;

    public UpdateProjectCommand(IProjectRepository repository, IProjectValidator validator)
    {
      _repository = repository;
      _validator = validator;
    }

    public async Task ExecuteAsync(DbProject project)
    {
      try
      {
        _validator.ValidateAndThrow(project);

        await _repository.UpdateAsync(project);
      }
      catch { }
    }
  }
}
