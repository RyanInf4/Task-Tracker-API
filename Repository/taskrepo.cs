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

}