using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskTracker.Models.DbModels;

namespace TaskTracker.EF.Configurations
{
  public class DbProjectConfiguration : IEntityTypeConfiguration<DbProject>
  {
    public void Configure(EntityTypeBuilder<DbProject> builder)
    {
      builder
        .ToTable(DbProject.TableName);

      builder
        .HasKey(p => p.Id);

      builder
        .Property(p => p.Name)
        .IsRequired();

      builder
        .HasMany(p => p.Tasks)
        .WithOne(t => t.Project);
    }
  }
}
