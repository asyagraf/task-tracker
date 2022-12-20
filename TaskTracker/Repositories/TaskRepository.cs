using Microsoft.EntityFrameworkCore;
using TaskTracker.EF;
using TaskTracker.Models.DbModels;
using TaskTracker.Repositories.Interfaces;

namespace TaskTracker.Repositories
{
  public class TaskRepository : ITaskRepository
  {
    private readonly TaskTrackerDbContext _dbContext;
    public TaskRepository(TaskTrackerDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task CreateAsync(DbTask task)
    {
      if (task is null) return;

      await _dbContext.Tasks.AddAsync(task);
      await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid taskId)
    {
      DbTask task = await _dbContext.Tasks.FindAsync(taskId);

      if (task is not null)
      {
        _dbContext.Tasks.Remove(task);
        await _dbContext.SaveChangesAsync();
      }
    }

    public async Task<IEnumerable<DbTask>> GetAllByIdAsync(Guid projectId)
    {
      return await _dbContext.Tasks.Where(t => t.ProjectId == projectId).ToListAsync();
    }

    public async Task<IEnumerable<DbTask>> GetAllAsync()
    {
      return await _dbContext.Tasks.ToListAsync();
    }

    public async Task<DbTask> GetAsync(Guid taskId)
    {
      return await _dbContext.Tasks.FindAsync(taskId);
    }

    public async Task UpdateAsync(DbTask task)
    {
      DbTask exTask = await _dbContext.Tasks.FindAsync(task.Id);

      if (exTask is not null)
      {
        exTask.Name = task.Name;
        exTask.Description = task.Description;
        exTask.Status = task.Status;
        exTask.Priority = task.Priority;
        exTask.ProjectId = task.ProjectId;

        await _dbContext.SaveChangesAsync();
      }
    }
  }
}
