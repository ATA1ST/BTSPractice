using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using MediatR;
using Core.Models;
using Core.Dtos.Task;

namespace Application.WorkTasks.Queries.GetWorkTaskById
{
    public class GetWorkTaskByIdHandler : IRequestHandler<GetWorkTaskByIdQuery, WorkTaskDto?>
    {
        private readonly IApplicationDBContext _context;

        public GetWorkTaskByIdHandler(IApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<WorkTaskDto?> Handle(GetWorkTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var task = await _context.Tasks.FindAsync(request.Id);
            if (task == null) return null;

            return new WorkTaskDto
            {
                Id = task.Id,
                CrewId = task.CrewId,
                ShiftId = task.ShiftId,
                Status = task.Status,
                PlannedQuantity = task.PlannedQuantity,
                ActualQuantity = task.ActualQuantity,
                MaterialId = task.MaterialId,
                UsedMaterialQuantity = task.UsedMaterialQuantity
            };
        }
    }
}