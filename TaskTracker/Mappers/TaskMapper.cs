using TaskTracker.Mappers.Interfaces;
using TaskTracker.Models.DbModels;
using TaskTracker.Models.DtoModels;
using TaskTracker.Models.Requests;

namespace TaskTracker.Mappers
{
  public class TaskMapper : ITaskMapper
  {
    // Convert request model to DB
    public DbTask Map(CreateTaskRequest request)
    {
      if (request is null)
      {
        return null;
      }

      return new DbTask()
      {
        Id = new Guid(),
        Name = request.Name,
        Description = request.Description,
        Status = request.Status,
        Priority = request.Priority,
        ProjectId = request.ProjectId
      };
    }

    // Convert DB model to DTO
    public TaskDto Map(DbTask task)
    {
      if (task is null)
      {
        return null;
      }

      return new TaskDto()
      {
        Name = task.Name,
        Description = task.Description,
        Status = task.Status,
        Priority = task.Priority
      };
    }
  }
}
