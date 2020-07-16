// This is an independent project of an individual developer. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
namespace ExtraGACUtil.Entities
{
    public class Library : BaseEntity
    {
        public string Path { get; set; }
        public bool IsActive { get; set; }
        public Project Project { get; set; }
    }
}
