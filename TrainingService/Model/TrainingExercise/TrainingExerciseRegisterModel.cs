using TrainingService.Model.ExerciseSeries;

namespace TrainingService.Model.TrainingExercise
{
    public class TrainingExerciseRegisterModel
    {
        public Guid ExerciseId { get; set; }

        public Guid TrainingId { get; set; }

        public byte Order { get; set; }

        public TimeSpan? Duration { get; set; }

        public List<ExerciseSeriesRegisterModel> Series { get; set; } 
    }
}
