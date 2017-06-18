using ShopOnline.Data.Infrastructure.Implements;
using ShopOnline.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data.Repositories
{
    public interface IOrderRepository
    {

    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {

        public OrderRepository(DbFactory dbFactory) :
            base(dbFactory)
        {

        }


    }
}
