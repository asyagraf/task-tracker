using TaskTracker.Models.DbModels;
using TaskTracker.Models.Enums;

namespace TaskTracker.Models.DtoModels
{
  public class TaskDto
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public StatusTask Status { get; set; }
    public int Priority { get; set; }
  }
}
