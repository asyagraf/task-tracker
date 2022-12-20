using Microsoft.EntityFrameworkCore;
using TaskTracker.EF;
using TaskTracker.Models.DbModels;
using TaskTracker.Repositories.Interfaces;

namespace TaskTracker.Repositories
{
  public class ProjectRepository : IProjectRepository
  {
    private readonly TaskTrackerDbContext _dbContext;
    public ProjectRepository(TaskTrackerDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task CreateAsync(DbProject project)
    {
      if (project is null) return;

      await _dbContext.Projects.AddAsync(project);
      await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid projectId)
    {
      DbProject project = await _dbContext.Projects.FindAsync(projectId);

      if (project is not null)
      {
        List<DbTask> tasks = await _dbContext.Tasks.Where(t => t.ProjectId == projectId).ToListAsync();

        _dbContext.Tasks.RemoveRange(tasks);
        _dbContext.Projects.Remove(project);

        await _dbContext.SaveChangesAsync();
      }
    }

    public async Task<IEnumerable<DbProject>> GetAllAsync()
    {
      return await _dbContext.Projects.ToListAsync();
    }

    public async Task<DbProject> GetAsync(Guid projectId)
    {
      return await _dbContext.Projects.FindAsync(projectId);
    }

    public async Task UpdateAsync(DbProject project)
    {
      if (project is null) return;

      DbProject exProject = await _dbContext.Projects.FindAsync(project.Id);

      if (exProject is not null)
      {
        exProject.Name = project.Name;
        exProject.Status = project.Status;
        exProject.Priority = project.Priority;
        exProject.StartDate = project.StartDate;
        exProject.CompletionDate = project.CompletionDate;

        await _dbContext.SaveChangesAsync();
      }
    }
  }
}
