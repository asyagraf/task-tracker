using System.Text.Json.Serialization;
using TaskTracker.Models.Enums;

namespace TaskTracker.Models.DbModels
{
  public class DbTask
  {
    [JsonIgnore]
    public const string TableName = "Tasks";

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public StatusTask Status { get; set; }
    public int Priority { get; set; }
    public Guid ProjectId { get; set; }
    [JsonIgnore]
    public DbProject Project { get; set; }

  }
}
