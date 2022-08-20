using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingLibrary.Entity
{
    [Table("ExerciseSeries")]
    public class ExerciseSeries
    {
        public Guid Id { get; set; }

        public Guid TrainingExerciseId { get; set; }
        public virtual TrainingExercise TrainingExercise {get;set;}

        public byte Order { get; set; } 

        public byte Reps { get; set; } 

        public double Weight { get; set; }

        public TimeSpan? RestTime { get; set; }
    }
}
