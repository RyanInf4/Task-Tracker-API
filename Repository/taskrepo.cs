class Repository
{
    static List<Task> AllTasks = new List<Task>();

    public void AddTask(Task task)
    {
        AllTasks.Add(task);
    }

    public void IdToTask(Task task)
    {
        task.Id = task.Id + 1;
    }
}