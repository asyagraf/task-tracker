using TaskTracker.Models.Requests;

namespace TaskTracker.Commands.Interfaces
{
  public interface ICreateProjectCommand
  {
    Task ExecuteAsync(CreateProjectRequest request);
  }
}
