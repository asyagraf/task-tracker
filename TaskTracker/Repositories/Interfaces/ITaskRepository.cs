using TaskTracker.Models.DbModels;

namespace TaskTracker.Repositories.Interfaces
{
  public interface ITaskRepository
  {
    Task<DbTask> GetAsync(Guid taskId);

    Task<IEnumerable<DbTask>> GetAllByIdAsync(Guid projectId);

    Task<IEnumerable<DbTask>> GetAllAsync();

    Task CreateAsync(DbTask task);

    Task UpdateAsync(DbTask task);

    Task DeleteAsync(Guid taskId);

  }
}
