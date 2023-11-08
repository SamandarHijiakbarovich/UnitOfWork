using Microsoft.EntityFrameworkCore;
using UnitOfWorkDemo.Core.Interfaces;

namespace UnitOfWorkDemo.Infastructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly DbContextClass _dbContext;
    public GenericRepository(DbContextClass dbContext)
    {
        _dbContext = dbContext;
    }


    public Task Add(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<T> GetById(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public async Task Add(T entity)
    {
        await _dbContext.Set<T>.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
    }

    public void Update(T entity)
    {
        _dbContext.Set<T>().Update(entity);
    }
}