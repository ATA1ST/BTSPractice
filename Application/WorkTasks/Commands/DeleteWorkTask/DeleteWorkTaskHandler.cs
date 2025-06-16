using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services;
using Core.Interfaces;
using MediatR;

namespace Application.WorkTasks.Commands.DeleteWorkTask
{
    public class DeleteWorkTaskHandler : IRequestHandler<DeleteWorkTaskCommand, bool>
    {
        public IApplicationDBContext _context;
        public TaskService _taskService;
        public DeleteWorkTaskHandler(TaskService taskService, IApplicationDBContext context)
        {
            _taskService = taskService;
            _context = context;
        } 
        public async Task<bool> Handle(DeleteWorkTaskCommand request, CancellationToken cancellationToken)
        {
            return await _taskService.DeleteAsync(request, cancellationToken); 
        }
    }
}