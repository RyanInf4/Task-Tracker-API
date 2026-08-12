using Microsoft.AspNetCore.Mvc;

namespace programming.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    
    [HttpGet]
    public IActionResult GetTasks ()
    {
        var taskDtos = Repository.AllTasks.Select(_task => new TaskDTO
        {
            Taskname = _task.Taskname,
            Difficulty = _task.Difficulty,
            State = _task.State,
            Priority = _task.Priority,
            Description = _task.Description


        }).ToList();

        return Ok(taskDtos);
    }

    [HttpPost]

    public IActionResult PostTask ([FromBody] Task task)
    {


        if (task.Taskname == String.Empty)
        {
            return BadRequest();
        }

        int Taskid = Repository.AddTask(task);

        return CreatedAtAction(nameof(PostTask), new {id = Taskid}, task);
    }

    [HttpGet("{id}")] 
    public IActionResult GetTaskById (int id)
    {
        var Task = Repository.TaskById(id);   

        if (Task == null)
        {
            return NotFound();
        }

        return Ok(TaskDTO.TransformDTO(Task));
    }

    [HttpPut("{id}")]

    public IActionResult PutTask (int id, [FromBody] Task task)
    {
        if (task.Id != id)
        {
            return BadRequest();
        }

        Repository.UpdateTask(task);

        return NoContent();
    }

    [HttpDelete("{id}")]

    public IActionResult DeleteTask (int id)
    {

        Repository.DeleteRepoTask(id);

        return NoContent();
    }

}
