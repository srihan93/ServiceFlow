using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ServiceFlow.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationContext _context;

        public Repository(ApplicationContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return 1;
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
            return _context.Set<T>().ToList();
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
            _context.Set<T>().Add(obj);
            return true;
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