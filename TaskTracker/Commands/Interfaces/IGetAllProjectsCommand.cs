using TaskTracker.Models.DtoModels;

namespace TaskTracker.Commands.Interfaces
{
  public interface IGetAllProjectsCommand
  {
    Task<IEnumerable<ProjectDto>> ExecuteAsync();
  }
}
