using ShopOnline.Data.Infrastructure.Implements;
using ShopOnline.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data.Repositories
{
    public interface IProductTagRepository
    {

    }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {

        public ProductTagRepository(DbFactory dbFactory) :
            base(dbFactory)
        {

        }


    }
}
