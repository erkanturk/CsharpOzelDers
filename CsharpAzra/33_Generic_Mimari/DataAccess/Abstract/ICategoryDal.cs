using _33_Generic_Mimari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Generic_Mimari.DataAccess.Abstract
{
    public interface ICategoryDal:IRepository<Categories>
    {
        void DeleteFromCategories(int categoryId,int productId);
        Categories GetByWithProducs(int productId);
    }
}
