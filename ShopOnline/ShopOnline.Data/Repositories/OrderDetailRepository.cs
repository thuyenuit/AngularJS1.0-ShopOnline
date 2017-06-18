using ShopOnline.Data.Infrastructure.Implements;
using ShopOnline.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data.Repositories
{

    public interface IOrderDetailRepository
    {

    }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {

        public OrderDetailRepository(DbFactory dbFactory) :
            base(dbFactory)
        {

        }


    }
}
