using TaskTracker.Mappers.Interfaces;
using TaskTracker.Models.DbModels;
using TaskTracker.Models.DtoModels;
using TaskTracker.Models.Requests;

namespace TaskTracker.Mappers
{
  public class ProjectMapper : IProjectMapper
  {
    // Convert request model to DB
    public DbProject Map(CreateProjectRequest request)
    {
      if (request is null)
      {
        return null;
      }

      return new DbProject()
      {
        Id = new Guid(),
        Name = request.Name,
        StartDate = request.StartDate,
        CompletionDate = request.CompletionDate,
        Status = request.Status,
        Priority = request.Priority
      };
    }

    // Convert DB model to DTO
    public ProjectDto Map(DbProject project)
    {
      if (project is null)
      {
        return null;
      }

      return new ProjectDto()
      {
        Name = project.Name,
        StartDate = project.StartDate,
        CompletionDate = project.CompletionDate,
        Status = project.Status,
        Priority = project.Priority
      };
    }
  }
}
