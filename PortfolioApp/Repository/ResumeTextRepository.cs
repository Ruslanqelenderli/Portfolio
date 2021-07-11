using PortfolioApp.DAL;
using PortfolioApp.Interface;
using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Repository
{
    public class ResumeTextRepository : GenericRepository<ResumeText>,IResumeTextRepository
    {
        public ResumeTextRepository(PortfolioDbContext portfolioDbContext) : base(portfolioDbContext) { }
    }
}
