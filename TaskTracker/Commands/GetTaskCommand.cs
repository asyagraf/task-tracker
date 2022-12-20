using TaskTracker.Commands.Interfaces;
using TaskTracker.Mappers.Interfaces;
using TaskTracker.Models.DtoModels;
using TaskTracker.Repositories.Interfaces;

namespace TaskTracker.Commands
{
  public class GetTaskCommand : IGetTaskCommand
  {
    private readonly ITaskRepository _repository;
    private readonly ITaskMapper _mapper;

    public GetTaskCommand(ITaskRepository repository, ITaskMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }
    public async Task<TaskDto> ExecuteAsync(Guid taskId)
    {
      return _mapper.Map(await _repository.GetAsync(taskId));
    }
  }
}
