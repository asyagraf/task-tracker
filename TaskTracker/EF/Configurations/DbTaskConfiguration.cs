using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskTracker.Models.DbModels;

namespace TaskTracker.EF.Configurations
{
  public class DbTaskConfiguration : IEntityTypeConfiguration<DbTask>
  {
    public void Configure(EntityTypeBuilder<DbTask> builder)
    {
      builder
        .ToTable(DbTask.TableName);

      builder
        .HasKey(t => t.Id);

      builder
        .Property(t => t.Name)
        .IsRequired();

      builder
        .Property(t => t.Description)
        .IsRequired();

      builder
        .HasOne(t => t.Project)
        .WithMany(p => p.Tasks)
        .HasForeignKey(t => t.ProjectId);
    }
  }
}
