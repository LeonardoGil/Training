using TrainingLibrary.Entity;
using TrainingORM.Interface;
using TrainingService.Interface;
using TrainingService.Model;

namespace TrainingService.Service.Register
{
    public partial class ExerciseRegisterService
    {
        private readonly IExerciseRepository _exerciseRepository;

        public ExerciseRegisterService(IExerciseRepository exerciseService)
        {
            _exerciseRepository = exerciseService;
        }
    }

    public partial class ExerciseRegisterService : IExerciseRegisterService
    {
        public void Register(ExerciseRegisterModel exercise)
        {
            var entity = new Exercise()
            {
                Id = Guid.NewGuid(),
                Description = exercise.Description,
                Observation = exercise.Observation,
            };

            _exerciseRepository.AddAndSaveChanges(entity);
        }

        public void Delete(Guid id)
        {
            var exercise = _exerciseRepository.GetAll().FirstOrDefault(x => x.Id == id)
                ?? throw new ArgumentException($"ExerciseId inexistente!");

            _exerciseRepository.DeleteAndSaveChanges(exercise);
        }
    }
}
