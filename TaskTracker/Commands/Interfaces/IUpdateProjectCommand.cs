using TaskTracker.Models.DbModels;

namespace TaskTracker.Commands.Interfaces
{
  public interface IUpdateProjectCommand
  {
    Task ExecuteAsync(DbProject project);
  }
}
