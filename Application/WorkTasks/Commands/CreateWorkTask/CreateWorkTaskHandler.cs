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

namespace Application.WorkTasks.Commands.CreateWorkTask
{
    public class CreateWorkTaskHandler : IRequestHandler<CreateWorkTaskCommand, int>
    {
        private readonly IApplicationDBContext _context;

        public CreateWorkTaskHandler(IApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateWorkTaskCommand request, CancellationToken cancellationToken)
        {
            var dto = new CreateWorkTaskDto
            {
                CrewId = request.CrewId,
                ShiftId = request.ShiftId,
                Status = request.Status,
                PlannedQuantity = request.PlannedQuantity,
                ActualQuantity = request.ActualQuantity,
                MaterialId = request.MaterialId,
                UsedMaterialQuantity = request.UsedMaterialQuantity
            };
            var task = WorkTaskMappers.ToWorkTaskFromCreateDto(dto);
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync(cancellationToken);
            return task.Id;
        }
    }
}