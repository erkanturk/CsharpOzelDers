using _33_Generic_Mimari.DataAccess.Abstract;
using _33_Generic_Mimari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Generic_Mimari.DataAccess.Concrete
{
    internal class OrderDal : GenericRepository<Orders, DataContext>, IOrderDal
    {
        public List<Orders> GetOrders(string userId)
        {
            throw new NotImplementedException();
        }
        public override void Create(Orders entity)
        {
            base.Create(entity);
        }
    }
}
