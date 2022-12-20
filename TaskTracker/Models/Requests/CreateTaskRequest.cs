using TaskTracker.Models.Enums;

namespace TaskTracker.Models.Requests
{
  public class CreateTaskRequest
  {
    public Guid ProjectId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public StatusTask Status { get; set; }
    public int Priority { get; set; }
  }
}
