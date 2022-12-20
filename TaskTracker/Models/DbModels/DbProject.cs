using System.Text.Json.Serialization;
using TaskTracker.Models.Enums;

namespace TaskTracker.Models.DbModels
{
  public class DbProject
  {
    [JsonIgnore]
    public const string TableName = "Projects";

    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? CompletionDate { get; set; }
    public StatusProject Status { get; set; }
    public int Priority { get; set; }
    [JsonIgnore]
    public ICollection<DbTask> Tasks { get; set; }

    public DbProject()
    {
      Tasks = new HashSet<DbTask>();
    }
  }
}
