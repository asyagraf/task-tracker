using TaskTracker.Models.Requests;

namespace TaskTracker.Commands.Interfaces
{
  public interface ICreateTaskCommand
  {
    Task ExecuteAsync(CreateTaskRequest request);
  }
}
