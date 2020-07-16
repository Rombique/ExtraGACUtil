// This is an independent project of an individual developer. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ExtraGACUtil.Entities;
using ExtraGACUtil.Interfaces;

namespace ExtraGACUtil.Repositories
{
    public class LibrariesRepository : GenericRepository<Library>, ILibrariesRepository
    {
        public LibrariesRepository(string connectionString)
        {
            _connectionString = connectionString;
            _tableName = "libraries";
        }
    }
}
