namespace TrainingORM.Interface
{
    public interface IBaseRepository<T> where T : class 
    {
        IQueryable<T> GetAll();

        void AddAndSaveChanges(T entity);

        void DeleteAndSaveChanges(T entity);
    }
}
