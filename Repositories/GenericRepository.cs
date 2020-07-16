// This is an independent project of an individual developer. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ExtraGACUtil.Entities;
using ExtraGACUtil.Interfaces;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ExtraGACUtil.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected string _tableName;
        protected string _connectionString;

        public void Add(T entity)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<T>(_tableName);
                collection.Insert(entity);
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<T>(_tableName);
                collection.Delete(id);
            }
        }

        public T GetOne(Expression<Func<T, bool>> expression)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<T>(_tableName);
                return collection.FindOne(expression);
            }
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> expression)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<T>(_tableName);
                return collection.Find(expression).ToList();
            }
        }

        public void Update(T entity)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<T>(_tableName);
                collection.Update(entity);
            }
        }
    }
}
