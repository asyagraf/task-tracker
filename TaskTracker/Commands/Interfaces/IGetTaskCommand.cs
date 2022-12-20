using TaskTracker.Models.DtoModels;

namespace TaskTracker.Commands.Interfaces
{
  public interface IGetTaskCommand
  {
    Task<TaskDto> ExecuteAsync(Guid taskId);
  }
}
