// This is an independent project of an individual developer. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Collections.Generic;

namespace ExtraGACUtil.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public List<Library> Libraries { get; set; }
    }
}
