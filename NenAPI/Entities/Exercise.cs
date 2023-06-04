using NenAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace NenAPI.Entities;
public class Exercise
{
    public Guid Id { get; set; }

    [StringLength(30)]
    public string Name { get; set; } // REQUIRED
    public MuscleRegion Region { get; set; } // REQUIRED

    [StringLength(200)]
    public string? Notes { get; set; } // User notes on the exercise
    public ExerciseType Type { get; set; } // REQUIRED
    public Muscle PrimaryMuscle { get; set; }  // REQUIRED  // Main muscle trained during this exercise
    public bool IsPublic { get; set; }

    public ApplicationUser User { get; set; }
    public List<DetailedExercise> DetailedExercises { get; set;}
}