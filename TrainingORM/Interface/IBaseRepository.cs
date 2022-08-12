namespace TrainingORM.Interface
{
    public interface IBaseRepository<T> where T : class 
    {
        IQueryable<T> Get();

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
