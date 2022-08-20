using TrainingService.Model.TrainingExercise;

namespace TrainingService.Model.Training
{
    public class TrainingRegisterModel
    {
        public DateTime Date { get; set; }
        
        public TimeSpan? Duration { get; set; }

        public List<TrainingExerciseRegisterModel> TrainingExercises { get; set; }
    }
}