using TrainingService.Model;

namespace TrainingService.Interface
{
    public interface IExerciseRegisterService
    {
        void Register(ExerciseRegisterModel exercise);

        void Delete(Guid id);
    }
}
