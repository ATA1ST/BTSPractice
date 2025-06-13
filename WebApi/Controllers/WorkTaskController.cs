using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using Application.Services;
using Application.Mappers;
using Core.Dtos.Task;
using MediatR;
using Application.WorkTasks.Commands.CreateWorkTask;
using Application.WorkTasks.Queries.GetWorkTaskById;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskService _taskService;
        private readonly IMediator _mediator;

        public TaskController(TaskService taskService, IMediator mediator)
        {
            _taskService = taskService;
            _mediator = mediator;
            
        }

        [HttpGet]
        public async Task<ActionResult<List<WorkTask>>> GetAll()
        {
            var tasks = await _taskService.GetAllAsync();
            return Ok(tasks);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateWorkTaskCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _mediator.Send(new GetWorkTaskByIdQuery(id));
            return user is null ? NotFound() : Ok(user);
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
