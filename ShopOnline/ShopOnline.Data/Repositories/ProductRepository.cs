using ShopOnline.Data.Infrastructure.Implements;
using ShopOnline.Data.Infrastructure.Interfaces;
using ShopOnline.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data.Repositories
{
    public interface IProductRepository: IRepository<Product>
    {
        //IEnumerable<Product> GetByAlias(string alias);
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {

        public ProductRepository(DbFactory dbFactory) :
            base(dbFactory)
        {

        }

        /*public IEnumerable<Product> GetByAlias(string alias)
        {
            return DbContext.Product.Where(x => x.ProductAlias == alias);
        }*/
    }
}
