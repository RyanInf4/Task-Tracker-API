class Repository
{
    public static List<Task> AllTasks = new List<Task>();

    public static void AddTask(Task task)
    {
        AllTasks.Add(task);
    }

    public static void IdToTask(Task task)
    {
        task.Id = task.Id + 1;
    }
}