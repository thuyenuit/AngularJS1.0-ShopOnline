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
    // định nghĩa thêm các method cần thêm không có sẵn trong RepositoryBase
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository: RepositoryBase<ProductCategory>, IProductCategoryRepository
    {

        public ProductCategoryRepository(IDbFactory dbFactory) :
            base(dbFactory)
        {

        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return DbContext.ProductCategory.Where(x => x.ProductCategoryAlias == alias);
        }
    }
}
