using TrainingLibrary.Entity;
using TrainingORM.Interface;
using TrainingService.Interface;
using TrainingService.Model;

namespace TrainingService.Service
{
    public partial class ExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;

        public ExerciseService(IExerciseRepository exerciseService)
        {
            _exerciseRepository = exerciseService;
        }
    }

    public partial class ExerciseService : IExerciseService
    {
        public void Register(ExerciseRegister exercise)
        {
            var entity = new Exercise()
            {
                Id = Guid.NewGuid(),
                Description = exercise.Description,
                Observation = exercise.Observation,
            };

            _exerciseRepository.Add(entity);
        }
    }
}
