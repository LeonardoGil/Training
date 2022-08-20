using TrainingORM.Contexto;
using TrainingORM.Interface;

namespace TrainingORM.Repository.Base
{
    public abstract class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : class
    {
        protected TrainingContext _context;

        public BaseRepository(TrainingContext context) { _context = context; }

        public void AddAndSaveChanges(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
            _context.SaveChanges();
        }

        public void DeleteAndSaveChanges(Entity entity)
        {
            _context.Set<Entity>().Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<Entity> GetAll()
        {
            return _context.Set<Entity>().AsQueryable();   
        }
    }
}
