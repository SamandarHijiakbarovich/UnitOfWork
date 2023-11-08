using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Interfaces;

namespace UnitOfWorkDemo.Infastructure.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWork
    {
        public IProductRepository Product => throw new NotImplementedException();

        public int Save()
        {
            throw new NotImplementedException();
        }
    }
}
