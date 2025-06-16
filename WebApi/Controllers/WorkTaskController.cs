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

using Application.WorkTasks.Commands.UpdateWorkTask;
using Application.WorkTasks.Commands.DeleteWorkTask;

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
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetWorkTaskByIdQuery(id));
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateWorkTaskCommand command)
        {
            if (id != command.Id)
                return BadRequest("ID in URL does not match ID in request body.");

            var result = await _mediator.Send(command);
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteWorkTaskCommand(id); 
            var result = await _mediator.Send(command);
            return result ? Ok() : NotFound();
        }
    }
}
