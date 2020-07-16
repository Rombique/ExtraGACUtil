// This is an independent project of an individual developer. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ExtraGACUtil.Entities;
using ExtraGACUtil.Interfaces;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraGACUtil.Repositories
{
    public class ProjectsRepository : GenericRepository<Project>, IProjectsRepository
    {
        public ProjectsRepository(string connectionString)
        {
            _connectionString = connectionString;
            _tableName = "projects";
        }
    }
}
