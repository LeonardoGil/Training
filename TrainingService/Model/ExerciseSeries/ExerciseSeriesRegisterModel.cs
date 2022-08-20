namespace TrainingService.Model.ExerciseSeries
{
    public class ExerciseSeriesRegisterModel
    {
        public byte Order { get; set; }

        public byte Reps { get; set; }

        public double Weight { get; set; }

        public TimeSpan? RestTime { get; set; }

        public Guid TrainingExerciseId { get; set; }
    }
}
