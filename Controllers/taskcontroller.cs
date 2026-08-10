using Microsoft.AspNetCore.Mvc;

namespace programming.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    
    [HttpGet]
    public IActionResult GetTasks ()
    {
        return Ok(Repository.AllTasks);
    }

    [HttpPost]

    public IActionResult PostTask ([FromBody] Task task)
    {
        if (task.Taskname == String.Empty)
        {
            return BadRequest();
        }

        int Taskid = Repository.AddTask(task);
        Taskid = task.Id;


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

        return Ok(Task);
    }
}
