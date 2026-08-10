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
        if (task.Taskname != String.Empty)
        {
        Repository.AddTask(task);
        Repository.IdToTask(task);
        }


        return CreatedAtAction(nameof(PostTask), new {id = task.Id}, task);

    }
}
