using Microsoft.EntityFrameworkCore;
using TaskTracker.Commands;
using TaskTracker.Commands.Interfaces;
using TaskTracker.EF;
using TaskTracker.Mappers;
using TaskTracker.Mappers.Interfaces;
using TaskTracker.Repositories;
using TaskTracker.Repositories.Interfaces;
using TaskTracker.Validators;
using TaskTracker.Validators.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IGetProjectCommand, GetProjectCommand>();
builder.Services.AddTransient<IGetTaskCommand, GetTaskCommand>();
builder.Services.AddTransient<ICreateProjectCommand, CreateProjectCommand>();
builder.Services.AddTransient<ICreateTaskCommand, CreateTaskCommand>();
builder.Services.AddTransient<IGetAllProjectsCommand, GetAllProjectsCommand>();
builder.Services.AddTransient<IGetAllTasksByIdCommand, GetAllTasksByIdCommand>();
builder.Services.AddTransient<IGetAllTasksCommand, GetAllTasksCommand>();
builder.Services.AddTransient<IDeleteProjectCommand, DeleteProjectCommand>();
builder.Services.AddTransient<IDeleteTaskCommand, DeleteTaskCommand>();
builder.Services.AddTransient<IUpdateProjectCommand, UpdateProjectCommand>();
builder.Services.AddTransient<IUpdateTaskCommand, UpdateTaskCommand>();

builder.Services.AddTransient<IProjectRepository, ProjectRepository>();
builder.Services.AddTransient<ITaskRepository, TaskRepository>();

builder.Services.AddTransient<ICreateProjectRequestValidator, CreateProjectRequestValidator>();
builder.Services.AddTransient<ICreateTaskRequestValidator, CreateTaskRequestValidator>();
builder.Services.AddTransient<ITaskValidator, TaskValidator>();
builder.Services.AddTransient<IProjectValidator, ProjectValidator>();

builder.Services.AddTransient<IProjectMapper, ProjectMapper>();
builder.Services.AddTransient<ITaskMapper, TaskMapper>();

builder.Services.AddDbContext<TaskTrackerDbContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnectionString")));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllers();

app.MapControllerRoute(
  name: "default",
  pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
