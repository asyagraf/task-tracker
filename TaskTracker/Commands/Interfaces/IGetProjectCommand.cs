using TaskTracker.Models.DtoModels;

namespace TaskTracker.Commands.Interfaces
{
  public interface IGetProjectCommand
  {
    Task<ProjectDto> ExecuteAsync(Guid projectId);
  }
}
