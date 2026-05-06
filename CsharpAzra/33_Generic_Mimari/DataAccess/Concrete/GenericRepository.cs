using _33_Generic_Mimari.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _33_Generic_Mimari.DataAccess.Concrete
{
    internal class GenericRepository<T, TContext> : IRepository<T> where T : class where TContext : DataContext, new()
    {
        public virtual void Create(T entity)
        {
            Console.WriteLine($"Oluşturma işlemi {entity.GetType()}");
        }

        public virtual void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T GetOne(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
