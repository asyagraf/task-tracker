using FluentValidation;
using TaskTracker.Commands.Interfaces;
using TaskTracker.Mappers.Interfaces;
using TaskTracker.Models.Requests;
using TaskTracker.Repositories.Interfaces;
using TaskTracker.Validators.Interfaces;

namespace TaskTracker.Commands
{
  public class CreateTaskCommand : ICreateTaskCommand
  {
    private readonly ITaskRepository _repository;
    private readonly ICreateTaskRequestValidator _validator;
    private readonly ITaskMapper _mapper;

    public CreateTaskCommand(ITaskRepository repository,
      ICreateTaskRequestValidator validator, ITaskMapper mapper)
    {
      _repository = repository;
      _validator = validator;
      _mapper = mapper;
    }

    public async Task ExecuteAsync(CreateTaskRequest request)
    {
      try
      {
        // Validation of request model
        _validator.ValidateAndThrow(request);

        // Map request to DB model and create
        await _repository.CreateAsync(_mapper.Map(request));
      }
      catch { }
    }
  }
}
