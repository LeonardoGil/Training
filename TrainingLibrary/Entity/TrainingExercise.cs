using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingLibrary.Entity
{
    [Table("TrainingExercise")]
    public class TrainingExercise
    {
        public Guid Id { get; set; }
        
        public Guid ExerciseId { get; set; }

        public Guid TrainingId { get; set; }

        public byte Order { get; set; }

        public TimeSpan? Duration { get; set; }

        public List<ExerciseSeries> Series { get; set; }
    }
}
