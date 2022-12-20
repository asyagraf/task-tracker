using TaskTracker.Models.DbModels;
using TaskTracker.Models.DtoModels;
using TaskTracker.Models.Requests;

namespace TaskTracker.Mappers.Interfaces
{
  public interface ITaskMapper
  {
    DbTask Map(CreateTaskRequest request);
    TaskDto Map(DbTask dbTask);
  }
}
