using TaskTracker.Commands.Interfaces;
using TaskTracker.Repositories.Interfaces;

namespace TaskTracker.Commands
{
  public class DeleteTaskCommand : IDeleteTaskCommand
  {
    private readonly ITaskRepository _repository;

    public DeleteTaskCommand(ITaskRepository repository)
    {
      _repository = repository;
    }
    public async Task ExecuteAsync(Guid taskId)
    {
      await _repository.DeleteAsync(taskId);
    }
  }
}
