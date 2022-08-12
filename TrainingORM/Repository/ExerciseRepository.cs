using TrainingLibrary.Entity;
using TrainingORM.Contexto;
using TrainingORM.Interface;
using TrainingORM.Repository.Base;

namespace TrainingORM.Repository
{
    public class ExerciseRepository : BaseRepository<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(TrainingContext context) : base(context)
        {
        }
    }
}
