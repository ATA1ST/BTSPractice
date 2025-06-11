using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Dtos.Task;
using WebApplication2.Interfaces;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDBContext _context;
        public TaskRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<WorkTask> CreateAsync(WorkTask taskModel)
        {
            await _context.Tasks.AddAsync(taskModel);
            await _context.SaveChangesAsync();
            return taskModel;
        }

        public async Task<WorkTask?> DeleteAsync(int id)
        {
            var workTaskModel = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == id);

            if (workTaskModel == null)
            {
                return null;
            }

            _context.Tasks.Remove(workTaskModel);
            await _context.SaveChangesAsync();
            return workTaskModel;
        }

        public async Task<List<WorkTask>> GetAllAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<WorkTask?> GetByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task<WorkTask?> UpdateAsync(int id, UpdateWorkTaskDto workTaskDto)
        {
            var existingWorkTask = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == id);

            if (existingWorkTask == null)
            {
                return null;
            }
            existingWorkTask.CrewId = workTaskDto.CrewId;
            existingWorkTask.ShiftId = workTaskDto.ShiftId;
            existingWorkTask.Status = workTaskDto.Status;
            existingWorkTask.PlannedQuantity = workTaskDto.PlannedQuantity;
            existingWorkTask.ActualQuantity = workTaskDto.ActualQuantity;
            existingWorkTask.MaterialId = workTaskDto.MaterialId;
            existingWorkTask.UsedMaterialQuantity = workTaskDto.UsedMaterialQuantity;

            await _context.SaveChangesAsync();
            return existingWorkTask;
        }
    }
}