public class TaskDTO
{

    public string Taskname {get; set;}
    public int Difficulty { get; set;}
    public string? Description {get; set;}
    public bool State {get; set;}
    public int Priority {get; set;}


        public static List<TaskDTO> TransformDTO (Task _task)
    {
        var taskDtos = Repository.AllTasks.Select(_task => new TaskDTO
        {
            Taskname = _task.Taskname,
            Difficulty = _task.Difficulty,
            State = _task.State,
            Priority = _task.Priority,
            Description = _task.Description


        }).ToList();

        return taskDtos;
    }
}