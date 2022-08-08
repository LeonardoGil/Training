using TrainingLibrary.Entity;
using TrainingORM.Contexto;

namespace TrainingConsole.Test
{
    public class TestEF
    {
        public static void Start()
        {
            using (var contexto = new TrainingContext())
            {
                var exercise = new Exercise()
                {
                    Id = Guid.NewGuid(),
                    Description = "Rosca Direta",
                    Observation = null
                };

                contexto.Exercise.Add(exercise);
                contexto.SaveChanges();

                var trainig = new Training()
                {
                    Id = Guid.NewGuid(),
                    Date = new DateTime(2022, 07, 08),
                    Duration = null,
                    Exercises = new List<TrainingExercise>()
                };

                var trainigExercise = new TrainingExercise()
                {
                    Duration = new TimeSpan(1, 10, 0),
                    ExerciseId = exercise.Id,
                    Id = Guid.NewGuid(),
                    Order = 1,
                    Series = new List<ExerciseSeries>(),
                    TrainingId = trainig.Id
                };

                var exerciseSerie = new ExerciseSeries()
                {
                    Id = Guid.NewGuid(),
                    Order = 1,
                    Reps = 10,
                    RestTime = null,
                    Weight = 14,
                    TrainingExerciseId = trainigExercise.Id
                };

                trainigExercise.Series.Add(exerciseSerie);
                trainig.Exercises.Add(trainigExercise);

                contexto.Training.Add(trainig);
                contexto.SaveChanges();
            }
        }
    }

}
