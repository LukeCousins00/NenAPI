using System.ComponentModel.DataAnnotations;

namespace NenAPI.Entities;
public class WorkoutProgram
{
    public Guid Id { get; set; }

    [StringLength(30)]
    public string Name { get; set; }
    public int NumberOfWeeks { get; set; }
    public bool IsActive { get; set; }  
    public bool IsPublic { get; set; }

    public List<Workout> Workouts { get; set; }
    public ApplicationUser User { get; set; }
    public CoverPhoto CoverPhoto { get; set; }
}