using ShopOnline.Data.Infrastructure.Implements;
using ShopOnline.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data.Repositories
{
    public interface IPostRepositorycs
    {

    }

    public class PostRepositorycs : RepositoryBase<Post>, IPostRepositorycs
    {

        public PostRepositorycs(DbFactory dbFactory) :
            base(dbFactory)
        {

        }


    }
}
