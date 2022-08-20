using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingLibrary.Entity
{
    [Table("Training")]
    public class Training
    {
        public Training()
        {
            Exercises = new List<TrainingExercise>();
        }

        public Guid Id { get; set; } 

        public DateTime Date { get; set; }
        
        public TimeSpan? Duration { get; set; }

        public virtual List<TrainingExercise> Exercises { get; set; }
    }
}
