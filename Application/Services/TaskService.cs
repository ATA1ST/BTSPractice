using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Core.Dtos.Task;
using Core.Interfaces;
using Application.WorkTasks.Commands.CreateWorkTask;
using Microsoft.EntityFrameworkCore;
using Application.WorkTasks.Commands.UpdateWorkTask;
using Application.WorkTasks.Commands.DeleteWorkTask;

namespace Application.Services
{
    public class TaskService
    {
        public ITaskRepository _repo;
        private readonly IApplicationDBContext _context;
        public TaskService(ITaskRepository repo, IApplicationDBContext context)
        {
            _context = context;
            _repo = repo;
        }

        public async Task<List<WorkTask>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }
        public async Task<WorkTask?> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }
        public async Task<int> CreateAsync(CreateWorkTaskCommand command, CancellationToken cancellationToken)
        {
            var task = new WorkTask
            {
                CrewId = command.CrewId,
                ShiftId = command.ShiftId,
                Status = command.Status,
                PlannedQuantity = command.PlannedQuantity,
                ActualQuantity = command.ActualQuantity,
                MaterialId = command.MaterialId,
                UsedMaterialQuantity = command.UsedMaterialQuantity
            };
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync(cancellationToken);
            return task.Id;
        }
        public async Task<bool> UpdateAsync(UpdateWorkTaskCommand request, CancellationToken cancellationToken)
        {
            var task = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (task == null)
                return false;

            task.CrewId = request.CrewId;
            task.ShiftId = request.ShiftId;
            task.Status = request.Status;
            task.PlannedQuantity = request.PlannedQuantity;
            task.ActualQuantity = request.ActualQuantity;
            task.MaterialId = request.MaterialId;
            task.UsedMaterialQuantity = request.UsedMaterialQuantity;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> DeleteAsync(DeleteWorkTaskCommand request, CancellationToken cancellationToken)
        {
            var task = await _repo.GetByIdAsync(request.Id);
            if (task == null)
            {
                return false;
            }

            await _repo.DeleteAsync(task.Id);
            return true;
        }
        


    }

}