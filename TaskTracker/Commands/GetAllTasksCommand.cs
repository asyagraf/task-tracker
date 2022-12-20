using TaskTracker.Commands.Interfaces;
using TaskTracker.Mappers.Interfaces;
using TaskTracker.Models.DbModels;
using TaskTracker.Models.DtoModels;
using TaskTracker.Repositories.Interfaces;

namespace TaskTracker.Commands
{
  public class GetAllTasksCommand : IGetAllTasksCommand
  {
    private readonly ITaskRepository _repository;
    private readonly ITaskMapper _mapper;

    public GetAllTasksCommand(ITaskRepository repository, ITaskMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    public async Task<IEnumerable<TaskDto>> ExecuteAsync()
    {
      var temp = (List<DbTask>)await _repository.GetAllAsync();

      return temp.Select(x => _mapper.Map(x));
    }
  }
}
