using PortfolioApp.DAL;
using PortfolioApp.Interface;
using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Repository
{
    public class SkillRepository : GenericRepository<Skill>,ISkillRepository
    {
        public SkillRepository(PortfolioDbContext portfolioDbContext) : base(portfolioDbContext) { }
    }
}
