using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Models.ViewModels
{
    public class OnePageViewModel
    {
        public virtual About About { get; set; }
        public virtual List<About> Abouts { get; set; }
        public virtual List<Skill> Skills { get; set; }
        public virtual SkillText SkillText { get; set; }
        public virtual ResumeText ResumeText { get; set; }
        public virtual ContactText ContactText { get; set; }
        public virtual ServiceText ServiceText { get; set; }
        public virtual List<Education> Educations { get; set; }
        public virtual List<Service> Services { get; set; }
        public virtual ProjectText ProjectTexts { get; set; }
        public virtual List<ProjectCategory> Categories { get; set; }
        public virtual List<Project> Projects { get; set; }
        public virtual List<ProjectViewModel> ProjectViewModels { get; set; }

    }
}
