using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Service
{
    public interface IGenericRepository<Table> where Table:class,new()
    {
        void Add(Table table);
        void Update(Table table);
        void Delete(Table table);
        List<Table> GetAll();
        Table GetById(Guid Id);
        
    }
}
