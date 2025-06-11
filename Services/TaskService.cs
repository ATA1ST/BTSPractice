using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Repositories;
using WebApplication2.Interfaces;
using WebApplication2.Models;
using WebApplication2.Dtos.Task;

namespace WebApplication2.Services
{
    public class TaskService
    {
        public ITaskRepository _repo;
        public TaskService(ITaskRepository repo)
        {
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
        public async Task<WorkTask> CreateAsync(WorkTask task)
        {
            return await _repo.CreateAsync(task);
        }
        public async Task<WorkTask?> UpdateAsync(int id, UpdateWorkTaskDto dto)
        {
            return await _repo.UpdateAsync(id, dto);
        }

        public async Task<WorkTask?> DeleteAsync(int id)
        {
            return await _repo.DeleteAsync(id);
        }
        


    }
}