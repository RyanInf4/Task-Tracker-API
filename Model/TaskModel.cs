using System.ComponentModel.DataAnnotations;
public class Task
{
    // Task has its difficulty, done or incomplete, name, description, priority
    [Required]
    [Range (0,10)]
    public int Difficulty { get; set;}
    public bool State {get; set;}

    [Required]
    public string? Taskname {get; set;}

    public string? Description {get; set;}

    [Required]
    [Range (0,10)]
    public int Priority {get; set;}

    public int Id {get; set;}

}