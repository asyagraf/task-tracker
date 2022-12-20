using Microsoft.AspNetCore.Mvc;
using TaskTracker.Commands.Interfaces;
using TaskTracker.Models.DbModels;
using TaskTracker.Models.DtoModels;
using TaskTracker.Models.Requests;

namespace TaskTracker.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class TaskController : ControllerBase
  {
    // Get task by Id
    [HttpGet("get")]
    public async Task<TaskDto> GetAsync([FromServices] IGetTaskCommand command, [FromQuery] Guid taskId)
    {
      return await command.ExecuteAsync(taskId);
    }

    // Get all project's tasks by its Id
    [HttpGet("getAllById")]
    public async Task<IEnumerable<TaskDto>> GetAllAsync([FromServices] IGetAllTasksByIdCommand command,
      [FromQuery] Guid projectId)
    {
      return await command.ExecuteAsync(projectId);
    }

    // Get all tasks
    [HttpGet("getAll")]
    public async Task<IEnumerable<TaskDto>> GetAllAsync([FromServices] IGetAllTasksCommand command)
    {
      return await command.ExecuteAsync();
    }

    // Create Task
    [HttpPost("create")]
    public async Task CreateAsync([FromServices] ICreateTaskCommand command,
      [FromBody] CreateTaskRequest request)
    {
      await command.ExecuteAsync(request);
    }

    // Delete Task by Id
    [HttpDelete("delete")]
    public async Task DeleteAsync([FromServices] IDeleteTaskCommand command, [FromQuery] Guid taskId)
    {
      await command.ExecuteAsync(taskId);
    }

    // Update Task
    [HttpPut("update")]
    public async Task UpdateAsync([FromServices] IUpdateTaskCommand command,
      [FromBody] DbTask task)
    {
      await command.ExecuteAsync(task);
    }
  }
}
