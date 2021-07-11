using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Models
{
    public class ProjectCategory:Base
    {
        public ProjectCategory()
        {
            Projects = new HashSet<Project>();
        }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
