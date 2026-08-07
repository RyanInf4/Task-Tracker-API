using Microsoft.AspNetCore.Mvc;

namespace programming.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    
    [HttpGet]
    public IActionResult GetTasks ()
    {
        

        return Ok();
    }

    [HttpPost]

    public CreatedAtActionResult PostTask ([FromBody] Task task)
    {
        
    }
}
