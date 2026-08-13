using System.Linq;
class Repository
{
    public static List<Task> AllTasks = new List<Task>();
    private static int AutoId = 1;
    

    public static int AddTask(Task task)
    {
        AutoId++;
        task.Id += AutoId;
        AllTasks.Add(task);
        
        
        return task.Id;
    }

    public static TaskDTO TaskById (int id)
    {
        var FindTaskId = AllTasks.FirstOrDefault(ExpectedId => ExpectedId.Id == id);

        var returnedDTO = TaskDTO.TransformDTO(FindTaskId);

            return returnedDTO;

    }

    public static TaskDTO UpdateTask (Task taskfrombody)
    {
        var FindTask = AllTasks.FirstOrDefault(ExpectedId => ExpectedId.Id == taskfrombody.Id);

        FindTask.Taskname = taskfrombody.Taskname;
        FindTask.Description = taskfrombody.Description;
        FindTask.Priority = taskfrombody.Priority;
        FindTask.State = taskfrombody.State;
        FindTask.Difficulty = taskfrombody.Difficulty;

         var returnedDTO = TaskDTO.TransformDTO(FindTask);

        return returnedDTO;
    }

    public static void DeleteRepoTask (int Id) {

        var FindTask = AllTasks.FirstOrDefault(Expect => Expect.Id == Id);

        if (FindTask != null)
        {
            AllTasks.Remove(FindTask);
        }
        
    }


}