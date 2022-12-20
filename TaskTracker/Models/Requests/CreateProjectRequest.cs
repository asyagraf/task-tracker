using TaskTracker.Models.Enums;

namespace TaskTracker.Models.Requests
{
  public class CreateProjectRequest
  {
    public string Name { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? CompletionDate { get; set; }
    public StatusProject Status { get; set; }
    public int Priority { get; set; }
  }
}
