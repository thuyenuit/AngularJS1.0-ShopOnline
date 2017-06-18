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
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCatgory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository: RepositoryBase<ProductCatgory>, IProductCategoryRepository
    {

        public ProductCategoryRepository(DbFactory dbFactory) :
            base(dbFactory)
        {

        }

        public IEnumerable<ProductCatgory> GetByAlias(string alias)
        {
            return DbContext.ProductCatgory.Where(x => x.ProductCatgoryAlias == alias);
        }
    }
}
