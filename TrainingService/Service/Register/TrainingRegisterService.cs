using AutoMapper;
using TrainingLibrary.Entity;
using TrainingORM.Interface;
using TrainingService.Interface;
using TrainingService.Model.Training;

namespace TrainingService.Service.Register
{
    public partial class TrainingRegisterService
    {
        private readonly ITrainingRepository _trainingRepository;
        private readonly ITrainingExerciseRepository _trainingExerciseRepository;
        private readonly IExerciseSeriesRepository _exerciseSeriesRepository;

        private readonly IMapper _mapper;

        public TrainingRegisterService(ITrainingRepository trainingRepository, 
                                       ITrainingExerciseRepository trainingExerciseRepository, 
                                       IExerciseSeriesRepository exerciseSeriesRepository,
                                       IMapper mapper)
        {
            _trainingRepository = trainingRepository;
            _trainingExerciseRepository = trainingExerciseRepository;
            _exerciseSeriesRepository = exerciseSeriesRepository;

            _mapper = mapper;
        }
    }

    public partial class TrainingRegisterService : ITrainingRegisterService
    {
        public void Register(TrainingRegisterModel trainingModel)
        {
            var training = _mapper.Map<Training>(trainingModel);
            var trainingExercise = _mapper.Map<TrainingExercise>(trainingModel.TrainingExercises);

            var ok = true;
        }
    }
}
