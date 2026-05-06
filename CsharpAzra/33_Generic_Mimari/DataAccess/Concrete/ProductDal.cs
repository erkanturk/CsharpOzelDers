using _33_Generic_Mimari.DataAccess.Abstract;
using _33_Generic_Mimari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Generic_Mimari.DataAccess.Concrete
{
    internal class ProductDal : GenericRepository<Product, DataContext>, IProductDal
    {
        public int GetCountByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Product GetProductDetails(int productId)
        {
            throw new NotImplementedException();
        }
        public override void Create(Product entity)
        {
            base.Create(entity);
        }
    }
}
