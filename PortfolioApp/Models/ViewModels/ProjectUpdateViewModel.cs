using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Models.ViewModels
{
    public class ProjectUpdateViewModel
    {
        public Project Projects { get; set; }
        public List<ProjectCategory> ProjectCategories { get; set; }
    }
}
