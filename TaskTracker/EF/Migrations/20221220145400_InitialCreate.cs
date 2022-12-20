using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using TaskTracker.Models.DbModels;
using TaskTracker.Models.Enums;

namespace TaskTracker.EF.Migrations
{
  [DbContext(typeof(TaskTrackerDbContext))]
  [Migration("20221220145400_InitialCreate")]
  public class InitialCreate : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
        name: DbTask.TableName,
        columns: table => new
        {
          Id = table.Column<Guid>(nullable: false),
          Name = table.Column<string>(nullable: false),
          Description = table.Column<string>(nullable: true),
          Status = table.Column<StatusTask>(nullable: false),
          Priority = table.Column<int>(nullable: false),
          ProjectId = table.Column<Guid>(nullable: false)
        },
        constraints: table =>
        {
          table.PrimaryKey($"PK_{DbTask.TableName}", x => x.Id);
        });

      migrationBuilder.CreateTable(
        name: DbProject.TableName,
        columns: table => new
        {
          Id = table.Column<Guid>(nullable: false),
          Name = table.Column<string>(nullable: false),
          StartDate = table.Column<DateTime>(nullable: true),
          CompletionDate = table.Column<DateTime>(nullable: true),
          Status = table.Column<StatusProject>(nullable: false),
          Priority = table.Column<int>(nullable: false)
        },
        constraints: table =>
        {
          table.PrimaryKey($"PK_{DbProject.TableName}", x => x.Id);
        });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(DbTask.TableName);

      migrationBuilder.DropTable(DbProject.TableName);
    }
  }
}
