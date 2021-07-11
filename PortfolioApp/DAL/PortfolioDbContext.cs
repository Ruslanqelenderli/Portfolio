using Microsoft.EntityFrameworkCore;
using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.DAL
{
    public class PortfolioDbContext:DbContext
    {
        public  PortfolioDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        
        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<SkillText> SkillTexts { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<ResumeText> ResumeTexts { get; set; }
        public virtual DbSet<ServiceText> ServiceTexts { get; set; }
        public virtual DbSet<ContactText> ContactTexts { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<PortfolioApp.Models.Service> Services { get; set; }
        public virtual DbSet<ProjectText> ProjectTexts { get; set; }
        public virtual DbSet<ProjectCategory> ProjectCategories { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
    }
}
