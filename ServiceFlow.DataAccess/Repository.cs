using Microsoft.EntityFrameworkCore;
using ServiceFlow.DataAccess.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ServiceFlow.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetMany(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public bool Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}