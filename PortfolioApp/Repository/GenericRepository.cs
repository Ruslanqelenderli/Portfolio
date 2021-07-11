using PortfolioApp.DAL;
using PortfolioApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Repository
{
    public class GenericRepository<Table> :IGenericRepository<Table> where Table:class,new() 
    {
        private readonly PortfolioDbContext _portfolioDbContext;
        public GenericRepository(PortfolioDbContext portfolioDbContext)
        {
            _portfolioDbContext = portfolioDbContext;
        }

        public void Add(Table table)
        {
            
            _portfolioDbContext.Set<Table>().Add(table);
            _portfolioDbContext.SaveChanges();
        }

        public void Update(Table table)
        {
            _portfolioDbContext.Set<Table>().Update(table);
            _portfolioDbContext.SaveChanges();
        }
        public void Delete(Table table)
        {
            _portfolioDbContext.Set<Table>().Remove(table);
            _portfolioDbContext.SaveChanges();
        }
        
        public List<Table> GetAll()
        {
            return _portfolioDbContext.Set<Table>().ToList();
        }
        public Table GetById(Guid Id)
        {
            return _portfolioDbContext.Set<Table>().Find(Id);
        }


    }
}
