using TaskTracker.Models.DtoModels;

namespace TaskTracker.Commands.Interfaces
{
  public interface IGetAllTasksCommand
  {
    Task<IEnumerable<TaskDto>> ExecuteAsync();
  }
}
