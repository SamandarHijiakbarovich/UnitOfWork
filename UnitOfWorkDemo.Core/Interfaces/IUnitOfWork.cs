namespace UnitOfWorkDemo.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Product{get;}
        int Save();
         
    }
}