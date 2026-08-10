using System.ComponentModel.DataAnnotations;
class Task
{
    // Task has its difficulty, done or incomplete, name, description, priority
    [Required]
    public int Difficulty { get; set;}
    public bool State {get; set;}

    [Required]
    public string Taskname {get; set;}

    public string? Description {get; set;}

    [Required]
    public int Priority {get; set;}

    public int Id {get; set;}

}