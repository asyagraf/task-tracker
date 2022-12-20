using TaskTracker.Models.DbModels;
using TaskTracker.Models.DtoModels;
using TaskTracker.Models.Requests;

namespace TaskTracker.Mappers.Interfaces
{
  public interface IProjectMapper
  {
    DbProject Map(CreateProjectRequest request);
    ProjectDto Map(DbProject dbProject);
  }
}
