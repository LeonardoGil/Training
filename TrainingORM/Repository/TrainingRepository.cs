using TrainingLibrary.Entity;
using TrainingORM.Contexto;
using TrainingORM.Interface;
using TrainingORM.Repository.Base;

namespace TrainingORM.Repository
{
    public class TrainingRepository : BaseRepository<Training>, ITrainingRepository
    {
        public TrainingRepository(TrainingContext context) : base(context)
        {
        }
    }
}
