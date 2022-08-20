using TrainingLibrary.Entity;
using TrainingORM.Contexto;
using TrainingORM.Interface;
using TrainingORM.Repository.Base;

namespace TrainingORM.Repository
{
    public class TrainingExerciseRepository : BaseRepository<TrainingExercise>, ITrainingExerciseRepository
    {
        public TrainingExerciseRepository(TrainingContext context) : base(context)
        {
        }
    }
}
