using ShopOnline.Data.Infrastructure.Implements;
using ShopOnline.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data.Repositories
{
    public interface ITagRepository
    {

    }

    public class TagRepository : RepositoryBase<SystemConfig>, ITagRepository
    {
        public TagRepository(DbFactory dbFactory) :
            base(dbFactory)
        {

        }


    }
}
