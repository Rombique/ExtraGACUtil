// This is an independent project of an individual developer. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ExtraGACUtil.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExtraGACUtil.Interfaces
{
    interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        T GetOne(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> expression);
    }
}
