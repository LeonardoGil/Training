using TrainingORM.Contexto;
using TrainingORM.Interface;

namespace TrainingORM.Repository.Base
{
    public abstract class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : class
    {
        protected TrainingContext _context;

        public BaseRepository(TrainingContext context) { _context = context; }

        public void Add(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Entity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entity> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
