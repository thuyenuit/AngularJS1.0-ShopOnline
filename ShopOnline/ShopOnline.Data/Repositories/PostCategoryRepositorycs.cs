using ShopOnline.Data.Infrastructure.Implements;
using ShopOnline.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data.Repositories
{
    public interface IPostCategoryRepositorycs
    {

    }

    public class PostCategoryRepositorycs : RepositoryBase<PostCategory>, IPostCategoryRepositorycs
    {

        public PostCategoryRepositorycs(DbFactory dbFactory) :
            base(dbFactory)
        {

        }


    }
}
