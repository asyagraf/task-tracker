using TaskTracker.Commands.Interfaces;
using TaskTracker.Repositories.Interfaces;

namespace TaskTracker.Commands
{
  public class DeleteProjectCommand : IDeleteProjectCommand
  {
    private readonly IProjectRepository _repository;

    public DeleteProjectCommand(IProjectRepository repository)
    {
      _repository = repository;
    }

    public async Task ExecuteAsync(Guid projectId)
    {
      await _repository.DeleteAsync(projectId);
    }
  }
}
