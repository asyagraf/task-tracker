namespace TaskTracker.Commands.Interfaces
{
  public interface IDeleteProjectCommand
  {
    Task ExecuteAsync(Guid projectId);
  }
}
