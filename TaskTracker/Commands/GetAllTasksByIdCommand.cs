using TaskTracker.Commands.Interfaces;
using TaskTracker.Mappers.Interfaces;
using TaskTracker.Models.DbModels;
using TaskTracker.Models.DtoModels;
using TaskTracker.Repositories.Interfaces;

namespace TaskTracker.Commands
{
  public class GetAllTasksByIdCommand : IGetAllTasksByIdCommand
  {
    private readonly ITaskRepository _repository;
    private readonly ITaskMapper _mapper;

    public GetAllTasksByIdCommand(ITaskRepository repository, ITaskMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }
    public async Task<IEnumerable<TaskDto>> ExecuteAsync(Guid projectId)
    {
      var temp = (List<DbTask>)await _repository.GetAllByIdAsync(projectId);
      return temp.Select(x => _mapper.Map(x));
    }
  }
}
