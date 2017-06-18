using ShopOnline.Data.Infrastructure.Implements;
using ShopOnline.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Data.Repositories
{
    public interface IMenuRepository
    {

    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {

        public MenuRepository(DbFactory dbFactory) :
            base(dbFactory)
        {

        }


    }
}
