using _33_Generic_Mimari.DataAccess.Abstract;
using _33_Generic_Mimari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Generic_Mimari.DataAccess.Concrete
{
    internal class CategoryDal : GenericRepository<Categories, DataContext>, ICategoryDal
    {
        public void DeleteFromCategories(int categoryId, int productId)
        {
            throw new NotImplementedException();
        }

        public Categories GetByWithProducs(int productId)
        {
            throw new NotImplementedException();
        }
        public override void Create(Categories entity)
        {
            base.Create(entity);
        }
        public override void Update(Categories entity)
        {

        }
        public override void Delete(Categories entity)
        {
            base.Delete(entity);
        }
    }
}
