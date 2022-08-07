using System.Data.Entity;
using TrainingLibrary.Entity;

namespace TrainingORM.Contexto
{
    public class TrainingContext : DbContext
    {
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<ExerciseSeries> ExerciseSeries { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<TrainingExercise> TrainingExercise { get; set; }
    }
}
