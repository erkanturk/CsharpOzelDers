using _33_Generic_Mimari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Generic_Mimari.DataAccess.Abstract
{
    public interface IProductDal:IRepository<Product>
    {
        int GetCountByCategory (int categoryId);
        Product GetProductDetails (int productId);

    }
}
