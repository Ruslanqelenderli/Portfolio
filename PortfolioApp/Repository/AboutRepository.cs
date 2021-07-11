using PortfolioApp.DAL;
using PortfolioApp.Models;
using PortfolioApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Repository
{
    public class AboutRepository : GenericRepository<About> ,IAboutRepository
    {
        public AboutRepository(PortfolioDbContext context) : base(context) { }
        
    }
}
