using Microsoft.AspNetCore.Mvc;

namespace programming.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    static List<Task> AllTasks = new List<Task>();


    [HttpGet]
    public void GetTasks ()
    {
        Task t1 = new Task(7, true, "Wash Dishes", "Wash all the dishes by 4pm", 6);
        AllTasks.Add(t1);

        foreach (var tasks in AllTasks)
        {
            Console.WriteLine(tasks);
        }
    }
}
