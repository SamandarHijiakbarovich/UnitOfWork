using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Infastructure.Repositories;

public class ProductRepository:GenericRepository<ProductDetails>,IProductRepository
{
    public ProductRepository(DbContextClass dbContext) :base(dbContext)
    {

    }
}
