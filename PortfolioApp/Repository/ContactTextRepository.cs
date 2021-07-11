using PortfolioApp.DAL;
using PortfolioApp.Interface;
using PortfolioApp.Models;

namespace PortfolioApp.Repository
{
    public class ContactTextRepository : GenericRepository<ContactText>,IContactTextRepository
    {
        public ContactTextRepository(PortfolioDbContext portfolioDbContext) : base(portfolioDbContext) { }
    }
}
