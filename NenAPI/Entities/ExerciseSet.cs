using Microsoft.AspNetCore.SignalR;

namespace NenAPI.Entities;

public class ExerciseSet
{
    public Guid Id { get; set; }
    public int Weight { get; set; }
    public int Reps { get; set; }
    public DetailedExercise Exercise { get; set; }
}