using System.Linq;
class Repository
{
    public static List<Task> AllTasks = new List<Task>();
    private static int AutoId = 1;
    

    public static int AddTask(Task task)
    {
        AllTasks.Add(task);
        AutoId++;
        task.Id += AutoId;

        return task.Id;
    }

    public static Task TaskById (int id)
    {
        var FindTaskId = AllTasks.FirstOrDefault(ExpectedId => ExpectedId.Id == id);

            return FindTaskId;

    }

    public static Task UpdateTask (Task taskfrombody)
    {
        var FindTask = AllTasks.FirstOrDefault(ExpectedId => ExpectedId.Id == taskfrombody.Id);

        if (FindTask != null)
        {
            FindTask.Id = taskfrombody.Id;
            FindTask.Difficulty = taskfrombody.Difficulty;
            FindTask.State = taskfrombody.State;
            FindTask.Taskname = taskfrombody.Taskname;
            FindTask.Description = taskfrombody.Description;
            FindTask.Priority = taskfrombody.Priority;

            return FindTask;
        }

        return null;
    }

    public static void UpdatePatchTask (Task taskfrombody)
    {
        var FindTask = AllTasks.FirstOrDefault(Expect => Expect.Id == taskfrombody.Id);

        if (taskfrombody != null) { 

            FindTask.Description == taskfrombody.Description;

            
        
        }

        
    }

}