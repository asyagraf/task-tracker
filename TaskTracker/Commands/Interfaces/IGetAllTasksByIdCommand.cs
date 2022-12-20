using TaskTracker.Models.DtoModels;

namespace TaskTracker.Commands.Interfaces
{
  public interface IGetAllTasksByIdCommand
  {
    Task<IEnumerable<TaskDto>> ExecuteAsync(Guid projectId);
  }
}
