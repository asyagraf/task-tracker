using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TaskTracker.Models.DbModels;

namespace TaskTracker.EF
{
  public class TaskTrackerDbContext : DbContext
  {
    public TaskTrackerDbContext(DbContextOptions<TaskTrackerDbContext> options) : base(options)
    {
      Database.Migrate();
    }

    public DbSet<DbTask> Tasks { get; set; }
    public DbSet<DbProject> Projects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
  }
}
