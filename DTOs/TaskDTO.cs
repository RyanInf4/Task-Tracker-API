public class TaskDTO
{

    public string? Taskname {get; set;}
    public int Difficulty { get; set;}
    public string? Description {get; set;}
    public bool State {get; set;}
    public int Priority {get; set;}


        public static TaskDTO TransformDTO (Task task)
    {

        TaskDTO _task = new TaskDTO();  {
            _task.Taskname = task.Taskname;
            _task.Difficulty = task.Difficulty;
            _task.State = task.State;
            _task.Priority = task.Priority;
            _task.Description = task.Description;
        }

    return _task;

    }
}