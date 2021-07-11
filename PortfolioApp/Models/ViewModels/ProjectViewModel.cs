using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Models.ViewModels
{
    public class ProjectViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string PhotoName { get; set; }
        public string Url { get; set; }
        public string Client { get; set; }
    }
}
