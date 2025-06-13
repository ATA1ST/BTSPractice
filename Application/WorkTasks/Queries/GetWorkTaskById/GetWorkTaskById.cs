using MediatR;
using Core.Dtos.Task;

namespace Application.WorkTasks.Queries.GetWorkTaskById;

public record GetWorkTaskByIdQuery(int Id) : IRequest<WorkTaskDto>;