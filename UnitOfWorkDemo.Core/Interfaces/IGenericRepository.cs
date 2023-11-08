namespace UnitOfWorkDemo.Core.Interfaces;

    public interface IGenericRepository<T> where T:class
    {
        Task<T> GetById(int Id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        void Delete(T entity);
        void Update(T entity);    
    }
