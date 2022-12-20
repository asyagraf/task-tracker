using TaskTracker.Models.DbModels;

namespace TaskTracker.Repositories.Interfaces
{
  public interface IProjectRepository
  {
    Task<DbProject> GetAsync(Guid projectId);

    Task<IEnumerable<DbProject>> GetAllAsync();

    Task CreateAsync(DbProject request);

    Task UpdateAsync(DbProject project);

    Task DeleteAsync(Guid projectId);
  }
}
