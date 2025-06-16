using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using MediatR;
using Core.Models;
using Core.Dtos.Task;
using Application.Mappers;
using Application.Services;

namespace Application.WorkTasks.Commands.CreateWorkTask
{
    public class CreateWorkTaskHandler : IRequestHandler<CreateWorkTaskCommand, int>
    {
        private readonly TaskService _taskService;

        public CreateWorkTaskHandler(TaskService taskService)
        {
            _taskService = taskService;
        }
        public async Task<int> Handle(CreateWorkTaskCommand request, CancellationToken cancellationToken)
        {
            return await _taskService.CreateAsync(request, cancellationToken);
        }
    }
}