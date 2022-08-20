using TrainingService.Model.Training;

namespace TrainingService.Interface
{
    public interface ITrainingRegisterService
    {
        void Register(TrainingRegisterModel trainingModel);
    }
}
