using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Core.Dtos.Task;

namespace Core.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<WorkTask>> GetAllAsync();
        Task<WorkTask?> GetByIdAsync(int id);
        Task<WorkTask> CreateAsync(WorkTask taskModel);
        Task<WorkTask?> UpdateAsync(int id, UpdateWorkTaskDto stockDto);
        Task<WorkTask?> DeleteAsync(int id);
    }
}