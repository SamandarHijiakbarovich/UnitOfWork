using System.Reflection.Emit;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Core.Interfaces
{
    public interface IProductRepository:IGenericRepository<ProductDetails>
    {
        
         
    }
}