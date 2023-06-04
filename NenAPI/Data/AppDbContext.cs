using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NenAPI.Entities;

namespace NenAPI.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<CoverPhoto> CoverPhoto { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<DetailedExercise> DetailedExercises { get; set; }
    public DbSet<Workout> Workouts { get; set; }
    public DbSet<ExerciseSet> Sets { get; set; }
    public DbSet<WorkoutProgram> Programs { get; set; }
}