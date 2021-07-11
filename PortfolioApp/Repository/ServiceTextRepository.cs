using PortfolioApp.DAL;
using PortfolioApp.Interface;
using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Repository
{
    public class ServiceTextRepository : GenericRepository<ServiceText>,IServiceTextRepository
    {
        public ServiceTextRepository(PortfolioDbContext portfolioDbContext) : base(portfolioDbContext) { }
    }
}
