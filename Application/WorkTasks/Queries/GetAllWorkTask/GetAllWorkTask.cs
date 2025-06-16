using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Dtos.Task;
using MediatR;

namespace Application.WorkTasks.Queries.GetAllWorkTask
{
    public record GetAllWorkTask() : IRequest<List<WorkTaskDto>>;
}