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
    public interface IPostCategoryRepositorycs : IRepository<PostCategory>
    {

    }

    public class PostCategoryRepositorycs : RepositoryBase<PostCategory>, IPostCategoryRepositorycs
    {

        public PostCategoryRepositorycs(IDbFactory dbFactory) :
            base(dbFactory)
        {

        }


    }
}
