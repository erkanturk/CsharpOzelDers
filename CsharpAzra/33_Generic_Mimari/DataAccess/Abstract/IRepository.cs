using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _33_Generic_Mimari.DataAccess.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int id);//Örneğin Ürün getir. Sipariş getir Kategori getir.

        T GetOne(Expression<Func<T, bool>> filter = null);//Koşullu getirme işlemi
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//Tüm değerleri getirir
        void Create (T entity);
        void Update (T entity);
        void Delete (T entity);
        
    }
}
