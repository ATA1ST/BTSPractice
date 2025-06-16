using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Application.Mappers;
using Application.Services;
using Application.WorkTasks.Commands.CreateWorkTask;
using Core.Dtos.Task;
using Core.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.WorkTasks.Commands.UpdateWorkTask
{
    public class UpdateWorkTaskHandler : IRequestHandler<UpdateWorkTaskCommand, bool>
    {
        private readonly IApplicationDBContext _context;
        private readonly TaskService _taskService;

        public UpdateWorkTaskHandler(IApplicationDBContext context, TaskService taskService)
        {
            _context = context;
            _taskService = taskService;
        }
        public async Task<bool> Handle(UpdateWorkTaskCommand request, CancellationToken cancellationToken)
        {
            return await _taskService.UpdateAsync(request, cancellationToken); 
        }
    }
}