namespace NenAPI.Entities;
public class DetailedExercise
{
    public Guid Id { get; set; }
    public DateTime? Date { get; set; } // Last date user submitted Sets for this exercise
    public int Sets { get; set; }
    public int LowReps { get; set; }
    public int HighReps { get; set; }
    public int Rest { get; set; } = 60; // Rest time in seconds between sets

    public Workout Workout { get; set; }
    public Exercise BaseInformation { get; set; } // Contains the name, icon, muscle group, type and Id
    public List<ExerciseSet> ExerciseSets { get; set; } // List of Sets => [No.Reps, Weight]  
}