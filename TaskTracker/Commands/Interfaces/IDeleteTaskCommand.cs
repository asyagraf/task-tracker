namespace TaskTracker.Commands.Interfaces
{
  public interface IDeleteTaskCommand
  {
    Task ExecuteAsync(Guid taskId);
  }
}
