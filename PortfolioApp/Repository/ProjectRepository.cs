﻿using PortfolioApp.DAL;
using PortfolioApp.Interface;
using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Repository
{
    public class ProjectRepository:GenericRepository<Project>,IProjectRepository
    {
        public ProjectRepository(PortfolioDbContext context) : base(context) { }
    }
}
