namespace TrainingLibrary.Entity
{
    public class ExerciseSeries
    {
        public Guid Id { get; set; }

        public Guid TrainingExerciseId { get; set; }

        public byte Order { get; set; } 

        public ushort Reps { get; set; } 

        public double Weight { get; set; }

        public TimeOnly? RestTime { get; set; }
    }
}
