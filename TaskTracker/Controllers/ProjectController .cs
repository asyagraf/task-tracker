using Microsoft.AspNetCore.Mvc;
using TaskTracker.Commands.Interfaces;
using TaskTracker.Models.DbModels;
using TaskTracker.Models.DtoModels;
using TaskTracker.Models.Requests;

namespace TaskTracker.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProjectController : ControllerBase
  {
    // Get project by Id
    [HttpGet("get")]
    public async Task<ProjectDto> GetAsync([FromServices] IGetProjectCommand command, [FromQuery] Guid projectId)
    {
      return await command.ExecuteAsync(projectId);
    }

    // Get all projects
    [HttpGet("getAll")]
    public async Task<IEnumerable<ProjectDto>> GetAllAsync([FromServices] IGetAllProjectsCommand command)
    {
      return await command.ExecuteAsync();
    }

    // Create project
    [HttpPost("create")]
    public async Task CreateAsync([FromServices] ICreateProjectCommand command,
      [FromBody] CreateProjectRequest request)
    {
      await command.ExecuteAsync(request);
    }

    // Delete project by Id
    [HttpDelete("delete")]
    public async Task DeleteAsync([FromServices] IDeleteProjectCommand command, [FromQuery] Guid projectId)
    {
      await command.ExecuteAsync(projectId);
    }

    // Update project
    [HttpPut("update")]
    public async Task UpdateAsync([FromServices] IUpdateProjectCommand command,
      [FromBody] DbProject project)
    {
      await command.ExecuteAsync(project);
    }
  }
}
