using TaskTracker.Commands.Interfaces;
using TaskTracker.Mappers.Interfaces;
using TaskTracker.Models.DbModels;
using TaskTracker.Models.DtoModels;
using TaskTracker.Repositories.Interfaces;

namespace TaskTracker.Commands
{
  public class GetAllProjectsCommand : IGetAllProjectsCommand
  {
    private readonly IProjectRepository _repository;
    private readonly IProjectMapper _mapper;
    public GetAllProjectsCommand(IProjectRepository repository, IProjectMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    public async Task<IEnumerable<ProjectDto>> ExecuteAsync()
    {
      var temp = (List<DbProject>)await _repository.GetAllAsync();

      return temp.Select(x => _mapper.Map(x));
    }
  }
}
