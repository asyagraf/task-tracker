using TaskTracker.Models.DbModels;

namespace TaskTracker.Commands.Interfaces
{
  public interface IUpdateTaskCommand
  {
    Task ExecuteAsync(DbTask task);
  }
}
