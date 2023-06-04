using System.ComponentModel.DataAnnotations;

namespace NenAPI.Entities;
public class Workout
{
    public Guid Id { get; set; }

    [StringLength(30)]
    public string Name { get; set; }
    public int Day { get; set; } // Day # in cycle of the program it will be in, Day 1/2/3/4/5/6/7
    public bool IsPublic { get; set; } = false;


    public List<DetailedExercise> Exercises { get; set; }
    public WorkoutProgram Program { get; set; }
}