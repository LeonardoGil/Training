using TrainingLibrary.Entity;
using TrainingORM.Contexto;
using TrainingORM.Interface;
using TrainingORM.Repository.Base;

namespace TrainingORM.Repository
{
    public class ExerciseSeriesRepository : BaseRepository<ExerciseSeries>, IExerciseSeriesRepository
    {
        public ExerciseSeriesRepository(TrainingContext context) : base(context)
        {
        }
    }
}
