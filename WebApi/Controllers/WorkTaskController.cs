using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Application.Services;
using Application.Mappers;
using Core.Dtos.Task;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<ActionResult<List<WorkTask>>> GetAll()
        {
            var tasks = await _taskService.GetAllAsync();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkTask>> GetById(int id)
        {
            var task = await _taskService.GetByIdAsync(id);
            if (task == null)
                return NotFound();
            return Ok(task);
        }

        [HttpPost]
        public async Task<ActionResult<WorkTask>> Create([FromBody]CreateWorkTaskDto dto)
        {
            var workTaskModel = dto.ToWorkTaskFromCreateDto();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var newTask = await _taskService.CreateAsync(workTaskModel);
            return CreatedAtAction(nameof(GetById), new { id = newTask.Id }, newTask);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WorkTask>> Update(int id, UpdateWorkTaskDto dto)
        {
            var updatedTask = await _taskService.UpdateAsync(id, dto);
            if (updatedTask == null)
                return NotFound();
            return Ok(updatedTask);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WorkTask>> Delete(int id)
        {
            var deletedTask = await _taskService.DeleteAsync(id);
            if (deletedTask == null)
                return NotFound();
            return Ok(deletedTask);
        }
    }
}
