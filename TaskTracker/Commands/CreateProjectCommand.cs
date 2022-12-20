using FluentValidation;
using TaskTracker.Commands.Interfaces;
using TaskTracker.Mappers.Interfaces;
using TaskTracker.Models.Requests;
using TaskTracker.Repositories.Interfaces;
using TaskTracker.Validators.Interfaces;

namespace TaskTracker.Commands
{
  public class CreateProjectCommand : ICreateProjectCommand
  {
    private readonly IProjectRepository _repository;
    private readonly ICreateProjectRequestValidator _validator;
    private readonly IProjectMapper _mapper;

    public CreateProjectCommand(IProjectRepository repository,
      ICreateProjectRequestValidator validator, IProjectMapper mapper)
    {
      _repository = repository;
      _validator = validator;
      _mapper = mapper;
    }

    public async Task ExecuteAsync(CreateProjectRequest request)
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
