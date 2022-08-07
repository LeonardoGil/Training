// See https://aka.ms/new-console-template for more information
using TrainingLibrary.Entity;
using TrainingORM.Contexto;

namespace TrainingConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Process Training.exe!");
            MockTest.On();

            Console.WriteLine("Exit code 0.");
        }
    }

    public class MockTest
    {
        public static void On()
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
                    Date = new DateOnly(2022, 07, 08),
                    Duration = null,
                    Exercises = new List<TrainingExercise>()
                    {
                        new TrainingExercise()
                        {
                            Duration = new TimeOnly(1, 10),
                            ExerciseId = exercise.Id,
                            Id = Guid.NewGuid(),
                            Order = 1,
                            Series = new List<ExerciseSeries>()
                            {
                                new ExerciseSeries()
                                {
                                    Id = Guid.NewGuid(),
                                    Order = 1,
                                    Reps = 10,
                                    RestTime = null,
                                    Weight = 14
                                }
                            }
                        }
                    }
                };
                
                contexto.Training.Add(trainig);
                contexto.SaveChanges();
            }
        }
    }
}
