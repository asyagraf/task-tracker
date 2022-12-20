using TaskTracker.Commands.Interfaces;
using TaskTracker.Mappers.Interfaces;
using TaskTracker.Models.DtoModels;
using TaskTracker.Repositories.Interfaces;

namespace TaskTracker.Commands
{
  public class GetProjectCommand : IGetProjectCommand
  {
    private readonly IProjectRepository _repository;
    private readonly IProjectMapper _mapper;

    public GetProjectCommand(IProjectRepository repository, IProjectMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    public async Task<ProjectDto> ExecuteAsync(Guid projectId)
    {
      return _mapper.Map(await _repository.GetAsync(projectId));
    }
  }
}
